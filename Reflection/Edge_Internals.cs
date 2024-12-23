using UnityEditor.Experimental.GraphView;

namespace Emilia.Reflection.Editor
{
    public static class EdgeExtension_Internals
    {
        public static void ForceUpdateEdgeControl_Internal(this Edge edge)
        {
            edge.ForceUpdateEdgeControl();
        }
    }
}