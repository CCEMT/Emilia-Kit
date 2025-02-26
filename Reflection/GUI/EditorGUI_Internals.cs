using UnityEditor;

namespace Emilia.Reflection.Editor
{
    public static class EditorGUI_Internals
    {
        public static bool IsEditingTextField_Internal()
        {
            return EditorGUI.IsEditingTextField();
        }
    }
}