using UnityEditor;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public static class EditorGUI_Internals
    {
        public static float MiniLabelW_Internal => EditorGUI.kMiniLabelW;
        public static float SpacingSubLabel_Internal => EditorGUI.kSpacingSubLabel;

        public static float SingleLineHeight_Internal => EditorGUI.kSingleLineHeight;

        public static bool IsEditingTextField_Internal() => EditorGUI.IsEditingTextField();

        public static void DrawOutline_Internal(Rect rect, float size, Color color)
        {
            EditorGUI.DrawOutline(rect, size, color);
        }

        public static void DragNumberValue_Internal(Rect dragHotZone, int id, bool isDouble, ref double doubleVal, ref long longVal, double dragSensitivity)
        {
            EditorGUI.DragNumberValue(dragHotZone, id, isDouble, ref doubleVal, ref longVal, dragSensitivity);
        }

        public static double DelayedDoubleField_Internal(
            Rect position,
            GUIContent label,
            double value,
            GUIStyle style) =>
            EditorGUI.DelayedDoubleFieldInternal(position, label, value, style);

        public static int DelayedIntField_Internal(
            Rect position,
            GUIContent label,
            int value,
            GUIStyle style) =>
            EditorGUI.DelayedIntFieldInternal(position, label, value, style);

        public static string TextField_Internal(int id, Rect position, GUIContent label, string text, GUIStyle style) => EditorGUI.TextFieldInternal(id, position, label, text, style);
    }
}