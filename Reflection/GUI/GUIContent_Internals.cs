using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public static class GUIContent_Internals
    {
        public static int GetHash_Internal(this GUIContent content) => content.hash;

        public static GUIContent Temp_Internal(string t) => GUIContent.Temp(t);

        public static GUIContent Temp_Internal(string t, string tooltip) => GUIContent.Temp(t, tooltip);

        public static GUIContent Temp_Internal(Texture i) => GUIContent.Temp(i);

        public static GUIContent Temp_Internal(Texture i, string tooltip) => GUIContent.Temp(i, tooltip);

        public static GUIContent Temp_Internal(string t, Texture i) => GUIContent.Temp(t, i);

        public static GUIContent[] Temp_Internal(string[] texts) => GUIContent.Temp(texts);

        public static GUIContent[] Temp_Internal(Texture[] images) => GUIContent.Temp(images);

        public static void ClearStaticCache_Internal()
        {
            GUIContent.ClearStaticCache();
        }
    }
}