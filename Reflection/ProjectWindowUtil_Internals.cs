using UnityEditor;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public static class ProjectWindowUtil_Internals
    {
        public static Object CreateScriptAssetFromTemplate_Internal(string pathName, string resourceFile) =>
            ProjectWindowUtil.CreateScriptAssetFromTemplate(pathName, resourceFile);

        public static void CreateScriptAssetFromTemplateFile_Internal(string templatePath, string defaultNewFileName)
        {
            ProjectWindowUtil.CreateScriptAssetFromTemplateFile(templatePath, defaultNewFileName);
        }

        public static void EndNameEditAction_Internal(EndNameEditAction action, int instanceId, string pathName, string resourceFile, bool accepted)
        {
            ProjectWindowUtil.EndNameEditAction(action, instanceId, pathName, resourceFile, accepted);
        }
    }
}
