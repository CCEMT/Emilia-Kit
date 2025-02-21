using UnityEditor;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public static class EditorGUIUtility_Internal
    {
        public static Texture2D LoadIcon_ByName(string name)
        {
            return EditorGUIUtility.LoadIcon(name);
        }
    }
}