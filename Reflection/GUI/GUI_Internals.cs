using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public static class GUI_Internals
    {
        public static bool DoButton_Internals(Rect position, int id, GUIContent content, GUIStyle style) => GUI.DoButton(position, id, content, style);

        public static void DoTextField_Internals(Rect position,
            int id,
            GUIContent content,
            bool multiline,
            int maxLength,
            GUIStyle style,
            string secureText,
            char maskChar) => GUI.DoTextField(position, id, content, multiline, maxLength, style, secureText, maskChar);
    }
}