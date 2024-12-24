using System;
using System.Collections.Generic;
using System.Linq;
using Sirenix.Utilities;
using UnityEditor;

namespace Emilia.DataBuildPipeline.Editor
{
    public class DataOutputManage : BuildSingleton<DataOutputManage>
    {
        private List<IDataOutput> _dataOutputs = new List<IDataOutput>();

        public DataOutputManage()
        {
            Type[] types = TypeCache.GetTypesDerivedFrom<IDataOutput>().Where((type) => type.IsAbstract == false && type.IsInterface == false).ToArray();
            int amount = types.Length;
            for (var i = 0; i < amount; i++)
            {
                Type type = types[i];
                object output = Activator.CreateInstance(type);
                IDataOutput dataOutput = output as IDataOutput;
                if (dataOutput != null) this._dataOutputs.Add(dataOutput);
            }
        }

        public List<IDataOutput> GetFinalizeBuildDisposeList(IBuildArgs buildArgs)
        {
            string pipelineName = buildArgs.pipelineName;
            List<IDataOutput> dataOutputs = new List<IDataOutput>();
            int amount = this._dataOutputs.Count;
            for (var i = 0; i < amount; i++)
            {
                IDataOutput dataOutput = this._dataOutputs[i];
                Type type = dataOutput.GetType();
                BuildPipelineAttribute attribute = type.GetCustomAttribute<BuildPipelineAttribute>();
                if (attribute == null) continue;
                if (attribute.pipelineName != pipelineName) continue;
                dataOutputs.Add(dataOutput);
            }

            return dataOutputs;
        }
    }
}