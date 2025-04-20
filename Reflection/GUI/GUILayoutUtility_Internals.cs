using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public static class GUILayoutUtility_Internals
    {
        public static Rect PeekNext_Internals() => GUILayoutUtility.current.topLevel.PeekNext();
    }
}