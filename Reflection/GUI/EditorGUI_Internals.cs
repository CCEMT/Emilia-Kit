using UnityEditor;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public static class EditorGUI_Internals
    {
        public static bool IsEditingTextField_Internal()
        {
            return EditorGUI.IsEditingTextField();
        }

        public static void DrawOutline_Internal(Rect rect, float size, Color color)
        {
            EditorGUI.DrawOutline(rect, size, color);
        }
    }
}