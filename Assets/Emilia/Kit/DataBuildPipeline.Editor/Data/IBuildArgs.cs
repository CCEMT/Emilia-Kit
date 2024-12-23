using System;

namespace Emilia.DataBuildPipeline.Editor
{
    public interface IBuildArgs
    {
        string pipelineName { get; }
        Action<BuildReport> onBuildComplete { get; }
    }
}