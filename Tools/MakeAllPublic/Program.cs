using System;
using System.IO;
using dnlib.DotNet;
using dnlib.DotNet.Writer;

namespace MakeAllPublic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dnSpy MakeAllClassesPublic Tool v1.0");
            Console.WriteLine("====================================");
            Console.WriteLine();

            if (args.Length == 0)
            {
                ShowUsage();
                return;
            }

            string inputPath = args[0];
            string outputPath = args.Length > 1 ? args[1] : GenerateOutputPath(inputPath);

            try
            {
                ProcessAssembly(inputPath, outputPath);
                Console.WriteLine($"处理完成! 输出文件: {outputPath}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"错误: {ex.Message}");
                Environment.Exit(1);
            }
        }

        static void ShowUsage()
        {
            Console.WriteLine("用法:");
            Console.WriteLine("  MakeAllPublic.exe <input.dll> [output.dll]");
            Console.WriteLine();
            Console.WriteLine("参数:");
            Console.WriteLine("  input.dll   - 输入的 .NET 程序集文件");
            Console.WriteLine("  output.dll  - 输出的程序集文件 (可选，默认为 input_public.dll)");
            Console.WriteLine();
            Console.WriteLine("功能:");
            Console.WriteLine("  • 将所有类型(class/interface/struct/enum)改为public");
            Console.WriteLine("  • 将所有方法、字段、属性、事件改为public");
            Console.WriteLine("  • 跳过编译器生成的特殊成员");
            Console.WriteLine();
            Console.WriteLine("示例:");
            Console.WriteLine("  MakeAllPublic.exe MyLibrary.dll");
            Console.WriteLine("  MakeAllPublic.exe MyLibrary.dll MyLibrary_Modified.dll");
        }

        static string GenerateOutputPath(string inputPath)
        {
            string directory = Path.GetDirectoryName(inputPath) ?? "";
            string filename = Path.GetFileNameWithoutExtension(inputPath);
            string extension = Path.GetExtension(inputPath);
            return Path.Combine(directory, $"{filename}_public{extension}");
        }

        static void ProcessAssembly(string inputPath, string outputPath)
        {
            if (! File.Exists(inputPath))
            {
                throw new FileNotFoundException($"输入文件不存在: {inputPath}");
            }

            Console.WriteLine($"正在处理: {inputPath}");

            ModuleDefMD module = ModuleDefMD.Load(inputPath);
            DetailedClassVisibilityPatcher patcher = new DetailedClassVisibilityPatcher(module);
            int modifiedCount = patcher.MakeAllClassesPublic();

            Console.WriteLine($"修改了 {modifiedCount} 个项目为 public");

            if (modifiedCount > 0)
            {
                ModuleWriterOptions writerOptions = new ModuleWriterOptions(module);
                module.Write(outputPath, writerOptions);
                Console.WriteLine($"已保存修改后的程序集");
            }
            else
            {
                File.Copy(inputPath, outputPath, true);
                Console.WriteLine("没有需要修改的项目，已复制原文件");
            }

            module.Dispose();

            string xmlDocFile = Path.ChangeExtension(inputPath, "xml");
            if (File.Exists(xmlDocFile))
            {
                string newXmlDocFile = Path.ChangeExtension(outputPath, "xml");
                File.Copy(xmlDocFile, newXmlDocFile, true);
                Console.WriteLine("已复制 XML 文档文件");
            }
        }
    }

    internal sealed class DetailedClassVisibilityPatcher
    {
        private readonly ModuleDefMD module;

        public DetailedClassVisibilityPatcher(ModuleDefMD module)
        {
            this.module = module ?? throw new ArgumentNullException(nameof(module));
        }

        public int MakeAllClassesPublic()
        {
            int modifiedCount = 0;

            foreach (TypeDef type in module.GetTypes())
            {
                if (type.IsGlobalModuleType) continue;
                if (MakeTypePublic(type)) modifiedCount++;
                modifiedCount += MakeAllMembersPublic(type);
            }

            return modifiedCount;
        }

        private bool MakeTypePublic(TypeDef type)
        {
            bool modified = false;

            if (type.DeclaringType is null)
            {
                if ((type.Attributes & TypeAttributes.VisibilityMask) == TypeAttributes.NotPublic)
                {
                    type.Attributes &= ~TypeAttributes.VisibilityMask;
                    type.Attributes |= TypeAttributes.Public;
                    modified = true;
                    Console.WriteLine($"  将顶级类型 '{type.FullName}' 改为 public");
                }
            }
            else
            {
                TypeAttributes visibility = type.Attributes & TypeAttributes.VisibilityMask;
                if (visibility != TypeAttributes.NestedPublic)
                {
                    type.Attributes &= ~TypeAttributes.VisibilityMask;
                    type.Attributes |= TypeAttributes.NestedPublic;
                    modified = true;
                    Console.WriteLine($"  将嵌套类型 '{type.FullName}' 改为 nested public");
                }
            }

            return modified;
        }

        private int MakeAllMembersPublic(TypeDef type)
        {
            int modifiedCount = 0;

            for (var i = 0; i < type.Fields.Count; i++)
            {
                FieldDef field = type.Fields[i];
                if (MakeFieldPublic(field))
                {
                    modifiedCount++;
                    Console.WriteLine($"    将字段 '{type.FullName}.{field.Name}' 改为 public");
                }
            }

            for (var i = 0; i < type.Methods.Count; i++)
            {
                MethodDef method = type.Methods[i];
                if (MakeMethodPublic(method))
                {
                    modifiedCount++;
                    string methodType = method.IsConstructor ? "构造函数" : "方法";
                    Console.WriteLine($"    将{methodType} '{type.FullName}.{method.Name}' 改为 public");
                }
            }

            for (var i = 0; i < type.Properties.Count; i++)
            {
                PropertyDef property = type.Properties[i];
                if (MakePropertyPublic(property))
                {
                    modifiedCount++;
                    Console.WriteLine($"    将属性 '{type.FullName}.{property.Name}' 改为 public");
                }
            }

            for (var i = 0; i < type.Events.Count; i++)
            {
                EventDef eventDef = type.Events[i];
                if (MakeEventPublic(eventDef))
                {
                    modifiedCount++;
                    Console.WriteLine($"    将事件 '{type.FullName}.{eventDef.Name}' 改为 public");
                }
            }

            return modifiedCount;
        }

        private bool MakeFieldPublic(FieldDef field)
        {
            if (field.IsCompilerControlled || field.Name.Contains("k__BackingField")) return false;

            FieldAttributes currentAccess = field.Attributes & FieldAttributes.FieldAccessMask;
            if (currentAccess != FieldAttributes.Public)
            {
                field.Attributes &= ~FieldAttributes.FieldAccessMask;
                field.Attributes |= FieldAttributes.Public;
                return true;
            }
            return false;
        }

        private bool MakeMethodPublic(MethodDef method)
        {
            if (method.IsRuntimeSpecialName && ! method.IsConstructor) return false;
            if (method.IsCompilerControlled && ! IsAccessorMethod(method)) return false;

            MethodAttributes currentAccess = method.Attributes & MethodAttributes.MemberAccessMask;
            if (currentAccess != MethodAttributes.Public)
            {
                method.Attributes &= ~MethodAttributes.MemberAccessMask;
                method.Attributes |= MethodAttributes.Public;
                return true;
            }
            return false;
        }

        private bool MakePropertyPublic(PropertyDef property)
        {
            bool modified = false;

            if (property.GetMethod != null && MakeMethodPublic(property.GetMethod)) modified = true;
            if (property.SetMethod != null && MakeMethodPublic(property.SetMethod)) modified = true;

            return modified;
        }

        private bool MakeEventPublic(EventDef eventDef)
        {
            bool modified = false;

            if (eventDef.AddMethod != null && MakeMethodPublic(eventDef.AddMethod)) modified = true;
            if (eventDef.RemoveMethod != null && MakeMethodPublic(eventDef.RemoveMethod)) modified = true;
            if (eventDef.InvokeMethod != null && MakeMethodPublic(eventDef.InvokeMethod)) modified = true;

            return modified;
        }

        private bool IsAccessorMethod(MethodDef method) => method.IsGetter || method.IsSetter || method.IsAddOn || method.IsRemoveOn || method.IsFire;
    }
}