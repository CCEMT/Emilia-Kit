using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;

namespace Emilia.DataBuildPipeline.Editor
{
    public class BuildPipelineManage : BuildSingleton<BuildPipelineManage>
    {
        private Dictionary<string, Type> pipelines = new Dictionary<string, Type>();

        public BuildPipelineManage()
        {
            Type[] types = TypeCache.GetTypesDerivedFrom<IBuildPipeline>().ToArray();
            int amount = types.Length;
            for (var i = 0; i < amount; i++)
            {
                Type type = types[i];
                if (type.IsAbstract || type.IsInterface) continue;

                BuildPipelineAttribute attribute = type.GetCustomAttribute<BuildPipelineAttribute>();
                if (attribute == null) continue;
                this.pipelines.Add(attribute.pipelineName, type);
            }
        }

        public IBuildPipeline GetPipeline(string pipelineName)
        {
            if (this.pipelines.TryGetValue(pipelineName, out Type type) == false) return default;
            IBuildPipeline pipeline = Activator.CreateInstance(type) as IBuildPipeline;
            return pipeline;
        }
    }
}