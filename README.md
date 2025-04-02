# Emilia-Kit

Emilia系列库的通用工具包  

* 数据构建管线实现
* 变量实现
* 引用池实现
* Odin拓展
* 编辑器通用工具类
* 数据结构实现
* OpenScript实现 可以通过Type找到对应的脚本文件
* Reflection实现 无反射直接访问内置或私有成员或类
* Odin序列化拓展实现 根据Tag进行序列化
* 第三方库Roslyn
* 第三方库UnityHook
* 第三方库TrueSync的定点数实现

## DataBuildPipeline（数据构建管线）

DataBuildPipeline设计之初是构建从Editor数据到Runtime数据的流水线，让整个构建过程更加规范并具有拓展性

**UniversalBuildPipeline**  

* 开始构建
* DataCollect 数据收集（收集编辑器数据，收集必要的数据，收集所引用的数据）
* DataDetection 数据检测（检查数据是否规范）
* DataBuildProcess 数据构建（正式开始构建）
* DataPostprocess 数据后处理（大部分时候用于生成一些额外数据）
* DataOutputProcess 数据输出（输出到Editor作为缓存，输出到文件，输出到运行器进行热重载）
* 构建结束输出构建报告

~~~csharp
//调用数据构建管线进行构建
DataBuildUtility.Build(BuildArgs)
~~~

**BuildPipelineAttribute**：为构建部件(管线，IDataCollect,IDataDetection等)指定构建管线的参数类型

**BuildSequenceAttribute**：指定该部件在当前流程的优先级

示例

~~~csharp
//初始数据
public class TestAsset 
{ 
    ...
}

//输出数据
public class TestOutputAsset 
{ 
    ...
}

//构建参数
public class TestBuildArgs : BuildArgs
{
    public TestAsset testAsset;

    ...

    public TestBuildArgs(TestAsset testAsset)
    {
        this.testAsset = testAsset;
    }
}

//构建容器 容器中包含数据构建时所需要的所有数据
public class TestBuildContainer : BuildContainer
{
    public TestAsset editorTestAsset;
    public TestOutputAsset outputAsset;
    ...
}

//构建管线
[BuildPipeline(typeof(TestBuildArgs))]//指定管线名称
public class TestBuildPipeline : UniversalBuildPipeline
{
    private TestBuildArgs testBuildArgs;

    protected override void RunInitialize()
    {
        base.RunInitialize();
        testBuildArgs = buildArgs as TestBuildArgs;
        ...
    }

    protected override IBuildContainer CreateContainer()
    {
        TestBuildContainer testBuildContainer = new TestBuildContainer();
        testBuildContainer.editorTestAsset = this.testBuildArgs.testAsset;
        ...

        return testBuildContainer;
    }
}

//数据检测
[BuildPipeline(typeof(TestBuildArgs)), BuildSequence(1000)]//指定管线名称
public class TestDataDetection : IDataDetection
{
    public bool Detection(IBuildContainer buildContainer, IBuildArgs buildArgs)
    {
        TestBuildContainer testBuildContainer = buildContainer as TestBuildContainer;
        if (testBuildContainer.editorTestAsset == null) return false;
        return true;
    }
}

//数据构建
[BuildPipeline(typeof(TestBuildArgs)), BuildSequence(1000)]//指定管线名称
public class TestDataBuild : IDataBuild
{
    public void Build(IBuildContainer buildContainer, Action onFinished)
    {
        TestBuildContainer testBuildContainer = buildContainer as TestBuildContainer;
        testBuildContainer.outputAsset = new TestOutputAsset();
        ...

        onFinished.Invoke();
    }
}

//数据输出
[BuildPipeline(typeof(TestBuildArgs)), BuildSequence(1000)]//指定管线名称
public class TestDataOutput : IDataOutput
{
    public void Output(IBuildContainer buildContainer, IBuildArgs buildArgs, Action onFinished)
    {
        TestBuildContainer testBuildContainer = buildContainer as TestBuildContainer;

        string json = JsonUtility.ToJson(testBuildContainer.outputAsset);
        string path = "Assets/...";
        
        if (File.Exists(path)) File.Delete(path);
        File.WriteAllText(path, json);
        
        AssetDatabase.Refresh();
        
        onFinished.Invoke();
    }
}
~~~

收集数据处理器的时候（IDataBuild,IDataPostproces,IDataOutput）会根据当前指定的参数类型进行收集，如果父类也有指定的处理器也会一并收集，当它们的优先级一样时，优先使用子类的处理器
