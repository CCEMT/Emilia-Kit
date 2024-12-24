using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UnityEditor;

namespace Emilia.DataBuildPipeline.Editor
{
    public class DataBuildManage : BuildSingleton<DataBuildManage>
    {
        private List<IDataBuild> _dataBuilds = new List<IDataBuild>();

        public DataBuildManage()
        {
            Type[] types = TypeCache.GetTypesDerivedFrom<IDataBuild>().Where((type) => type.IsAbstract == false && type.IsInterface == false).ToArray();
            int amount = types.Length;
            for (var i = 0; i < amount; i++)
            {
                Type type = types[i];
                object dataBuild = Activator.CreateInstance(type);
                IDataBuild build = dataBuild as IDataBuild;
                if (build == null) continue;
                this._dataBuilds.Add(build);
            }
        }

        public List<IDataBuild> GetDataBuildList(IBuildArgs buildArgs)
        {
            string pipelineName = buildArgs.pipelineName;
            List<IDataBuild> list = new List<IDataBuild>();

            int amount = this._dataBuilds.Count;
            for (int i = 0; i < amount; i++)
            {
                IDataBuild build = this._dataBuilds[i];
                Type type = build.GetType();
                BuildPipelineAttribute attribute = type.GetCustomAttribute<BuildPipelineAttribute>();
                if (attribute == null) continue;
                if (attribute.pipelineName != pipelineName) continue;
                list.Add(build);
            }

            list.Sort((a, b) => {
                BuildSequenceAttribute attributeA = a.GetType().GetCustomAttribute<BuildSequenceAttribute>();
                BuildSequenceAttribute attributeB = b.GetType().GetCustomAttribute<BuildSequenceAttribute>();
                return attributeA.priority.CompareTo(attributeB.priority);
            });

            return list;
        }
    }
}