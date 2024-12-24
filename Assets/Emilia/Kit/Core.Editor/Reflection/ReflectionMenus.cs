using System.Diagnostics;
using System.IO;
using UnityEditor;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace Emilia.Reflection.Editor
{
    public static class ReflectionMenus
    {
        [MenuItem("Tools/Emilia/Build Reflection")]
        public static void BuildReflection()
        {
            string toolsPath = $"{Directory.GetParent(Application.dataPath)}/Tools";

            ProcessStartInfo build = new ProcessStartInfo($"{toolsPath}/build-reflection.bat");
            build.WorkingDirectory = toolsPath;
            build.CreateNoWindow = true;
            build.UseShellExecute = false;

            Process buildProcess = Process.Start(build);
            buildProcess.WaitForExit();

            buildProcess.Dispose();

            AssetDatabase.SaveAssets();
            AssetDatabase.Refresh();

            Debug.Log("Build Reflection Finish");
        }
    }
}