using UnityEditor;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public static class EditorGUILayout_Internals
    {
        public static Rect LastRect_Internals
        {
            get => EditorGUILayout.s_LastRect;
            set => EditorGUILayout.s_LastRect = value;
        }

        public static Rect BeginHorizontal_Internals(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
        {
            return EditorGUILayout.BeginHorizontal(content, style, options);
        }

        public static Rect BeginVertical_Internals(GUIContent content, GUIStyle style, params GUILayoutOption[] options)
        {
            return EditorGUILayout.BeginVertical(content, style, options);
        }

        public static Vector2 BeginScrollView_Internals(Vector2 scrollPosition, bool alwaysShowHorizontal, bool alwaysShowVertical, GUIStyle horizontalScrollbar, GUIStyle verticalScrollbar,
            params GUILayoutOption[] options)
        {
            return EditorGUILayout.BeginScrollView(scrollPosition, alwaysShowHorizontal, alwaysShowVertical, horizontalScrollbar, verticalScrollbar, options);
        }
    }
}