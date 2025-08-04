using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public static class SearchTreeGroupEntry_Internals
    {
        public static int GetSelectedIndex(this SearchTreeGroupEntry groupEntry) => groupEntry.selectedIndex;

        public static void SetSelectedIndex(this SearchTreeGroupEntry groupEntry, int index) => groupEntry.selectedIndex = index;

        public static Vector2 GetScrollPosition(this SearchTreeGroupEntry groupEntry) => groupEntry.scroll;

        public static void SetScrollPosition(this SearchTreeGroupEntry groupEntry, Vector2 scroll) => groupEntry.scroll = scroll;
    }
}