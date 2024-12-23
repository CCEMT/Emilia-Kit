using System;

namespace Emilia.DataBuildPipeline.Editor
{
    [AttributeUsage(AttributeTargets.Class)]
    public class BuildPipelineAttribute : Attribute
    {
        public string pipelineName;

        public BuildPipelineAttribute(string pipelineName)
        {
            this.pipelineName = pipelineName;
        }
    }
}