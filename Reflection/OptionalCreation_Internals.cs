using System;
using System.Reflection;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Emilia.Reflection.Editor
{
    public static class AudioMixerController_Internals
    {
        private static readonly MethodInfo CreateMixerControllerAtPathMethod = typeof(EditorApplication).Assembly
            .GetType("UnityEditor.Audio.AudioMixerController")
            ?.GetMethod("CreateMixerControllerAtPath", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, new[] { typeof(string) }, null);

        public static bool isAvailable_Internal => CreateMixerControllerAtPathMethod != null;

        public static Object CreateMixerControllerAtPath_Internal(string path) =>
            CreateMixerControllerAtPathMethod?.Invoke(null, new object[] { path }) as Object;
    }

    public static class UIElementsTemplate_Internals
    {
        private static readonly MethodInfo CreateUxmlTemplateMethod = typeof(EditorApplication).Assembly
            .GetType("UnityEditor.UIElements.UIElementsTemplate")
            ?.GetMethod("CreateUXMLTemplate", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, new[] { typeof(string), typeof(string) }, null);

        public static bool isAvailable_Internal => CreateUxmlTemplateMethod != null;

        public static string CreateUXMLTemplate_Internal(string folder, string uxmlContent = "") =>
            CreateUxmlTemplateMethod?.Invoke(null, new object[] { folder, uxmlContent }) as string;
    }

    public static class TimelineUtility_Internals
    {
        private static readonly MethodInfo CreateAndSaveTimelineAssetMethod = FindTypeInCurrentDomain("UnityEditor.Timeline.TimelineUtility")
            ?.GetMethod("CreateAndSaveTimelineAsset", BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic, null, new[] { typeof(string) }, null);

        public static bool isAvailable_Internal => CreateAndSaveTimelineAssetMethod != null;

        public static void CreateAndSaveTimelineAsset_Internal(string path)
        {
            CreateAndSaveTimelineAssetMethod?.Invoke(null, new object[] { path });
        }

        private static Type FindTypeInCurrentDomain(string fullName)
        {
            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            for (int i = 0; i < assemblies.Length; i++)
            {
                Type type = assemblies[i].GetType(fullName, false);
                if (type != null)
                    return type;
            }

            return null;
        }
    }
}
