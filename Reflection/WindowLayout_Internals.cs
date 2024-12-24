using UnityEditor;

namespace Emilia.Reflection.Editor
{
    public static class WindowLayout_Internals
    {
        public static void LoadLayoutFromAsset_Internals(string assetPath)
        {
            WindowLayout.LoadWindowLayout(assetPath, false);
        }

        public static void SaveLayout_Internals(string path)
        {
            WindowLayout.SaveWindowLayout(path);
        }
    }
}