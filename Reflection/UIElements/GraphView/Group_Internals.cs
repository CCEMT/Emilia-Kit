using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine.UIElements;

namespace Emilia.Reflection.Editor
{
    public static class GroupExtension_Internals
    {
        public static void OnStartDragging_Internals(this Group self, IMouseEvent evt, IEnumerable<GraphElement> elements)
        {
            self.OnStartDragging(evt, elements);
        }
    }
}