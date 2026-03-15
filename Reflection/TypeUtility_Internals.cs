using System;
using System.Reflection;

namespace Emilia.Reflection.Editor
{
    public static class TypeUtility_Internals
    {
        public static Type GetType_Internal(string assemblyQualifiedTypeName)
        {
            if (string.IsNullOrWhiteSpace(assemblyQualifiedTypeName))
                return null;

            Type type = Type.GetType(assemblyQualifiedTypeName, false);
            if (type != null)
                return type;

            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            for (int i = 0; i < assemblies.Length; i++)
            {
                try
                {
                    type = assemblies[i].GetType(assemblyQualifiedTypeName, false);
                    if (type != null)
                        return type;
                }
                catch
                {
                    // Ignore partially loaded assemblies and keep scanning.
                }
            }

            int commaIndex = assemblyQualifiedTypeName.IndexOf(',');
            if (commaIndex > 0)
            {
                string fullName = assemblyQualifiedTypeName.Substring(0, commaIndex).Trim();
                for (int i = 0; i < assemblies.Length; i++)
                {
                    try
                    {
                        type = assemblies[i].GetType(fullName, false);
                        if (type != null)
                            return type;
                    }
                    catch
                    {
                        // Ignore partially loaded assemblies and keep scanning.
                    }
                }
            }

            return null;
        }
    }

    public static class OptionalTypes_Internals
    {
        public static Type PanelSettingsType_Internal => TypeUtility_Internals.GetType_Internal("UnityEngine.UIElements.PanelSettings, UnityEngine.UIElementsModule");

        public static Type TimelineAssetType_Internal => TypeUtility_Internals.GetType_Internal("UnityEngine.Timeline.TimelineAsset, Unity.Timeline");

        public static Type SignalAssetType_Internal => TypeUtility_Internals.GetType_Internal("UnityEngine.Timeline.SignalAsset, Unity.Timeline");

        public static Type BrushType_Internal => TypeUtility_Internals.GetType_Internal("UnityEditor.Brush, UnityEditor");
    }
}
