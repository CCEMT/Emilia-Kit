using UnityEditor;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public static class EditorGUIUtility_Internal
    {
        public static Texture2D FindTexture_Internal(string name) => EditorGUIUtility.FindTexture(name);

        public static Texture2D LoadIcon_Internal(string name) => EditorGUIUtility.LoadIcon(name);
    }
}