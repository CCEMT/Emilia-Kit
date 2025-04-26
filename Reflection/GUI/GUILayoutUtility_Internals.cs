using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public static class GUILayoutUtility_Internals
    {
        public static Rect PeekNext_Internals() => GUILayoutUtility.current.topLevel.PeekNext();

        public static int GetTopLevelEntryCount_Internals() => GUILayoutUtility.current.topLevel.entries.Count;

        public static int GetTopLevelCurrentCount_Internals() => GUILayoutUtility.current.topLevel.m_Cursor;
    }
}