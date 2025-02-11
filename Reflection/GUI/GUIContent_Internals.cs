using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public static class GUIContent_Internals
    {
        public static int GetHash_Internal(this GUIContent content)
        {
            return content.hash;
        }

        public static GUIContent Temp_Internal(string t)
        {
            return GUIContent.Temp(t);
        }

        public static GUIContent Temp_Internal(string t, string tooltip)
        {
            return GUIContent.Temp(t, tooltip);
        }

        public static GUIContent Temp_Internal(Texture i)
        {
            return GUIContent.Temp(i);
        }

        public static GUIContent Temp_Internal(Texture i, string tooltip)
        {
            return GUIContent.Temp(i, tooltip);
        }

        public static GUIContent Temp_Internal(string t, Texture i)
        {
            return GUIContent.Temp(t, i);
        }

        public static GUIContent[] Temp_Internal(string[] texts)
        {
            return GUIContent.Temp(texts);
        }

        public static GUIContent[] Temp_Internal(Texture[] images)
        {
            return GUIContent.Temp(images);
        }

        public static void ClearStaticCache_Internal()
        {
            GUIContent.ClearStaticCache();
        }
    }
}