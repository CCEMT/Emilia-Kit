using UnityEngine;

namespace Emilia.DataBuildPipeline.Editor
{
    public static class DataBuildUtility
    {
        public static void Build(BuildArgs buildArgs)
        {
            if (string.IsNullOrEmpty(buildArgs.pipelineName))
            {
                Debug.LogError("未指定 构建管线 !");
                return;
            }

            IBuildPipeline defaultPipeline = BuildPipelineManage.instance.GetPipeline(buildArgs.pipelineName);
            defaultPipeline.Run(buildArgs);
        }
    }
}