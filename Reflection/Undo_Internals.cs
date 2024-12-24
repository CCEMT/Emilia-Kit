using UnityEditor;

namespace Emilia.Reflection.Editor
{
    public static class Undo_Internals
    {
        public static void OnSelectionUndo_Internals(bool redo)
        {
            Undo.OnSelectionUndo(redo);
        }
    }
}