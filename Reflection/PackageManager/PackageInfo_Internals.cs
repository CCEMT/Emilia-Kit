using UnityEditor.PackageManager;

namespace Emilia.Reflection.Editor
{
    public static class PackageInfoExtension_Internals
    {
        public static bool hideInEditor_Internal(this PackageInfo self) => self.hideInEditor;
    }
}