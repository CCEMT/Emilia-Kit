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

        public static Vector2 BeginVerticalScrollView(
            Vector2 scrollPosition,
            params GUILayoutOption[] options)
        {
            return EditorGUILayout.BeginVerticalScrollView(scrollPosition, options);
        }

        public static Vector2 BeginVerticalScrollView(
            Vector2 scrollPosition,
            bool alwaysShowVertical,
            GUIStyle verticalScrollbar,
            GUIStyle background,
            params GUILayoutOption[] options)
        {
            return EditorGUILayout.BeginVerticalScrollView(scrollPosition, alwaysShowVertical, verticalScrollbar, background, options);
        }

        public static Vector2 BeginHorizontalScrollView(
            Vector2 scrollPosition,
            params GUILayoutOption[] options)
        {
            return EditorGUILayout.BeginHorizontalScrollView(scrollPosition, options);
        }

        public static Vector2 BeginHorizontalScrollView(
            Vector2 scrollPosition,
            bool alwaysShowHorizontal,
            GUIStyle horizontalScrollbar,
            GUIStyle background,
            params GUILayoutOption[] options)
        {
            return EditorGUILayout.BeginHorizontalScrollView(scrollPosition, alwaysShowHorizontal, horizontalScrollbar, background, options);
        }

        public static void EndScrollView(bool handleScrollWheel)
        {
            EditorGUILayout.EndScrollView(handleScrollWheel);
        }
    }
}