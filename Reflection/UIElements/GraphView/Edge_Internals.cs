using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

namespace Emilia.Reflection.Editor
{
    public static class EdgeExtension_Internals
    {
        public static void ForceUpdateEdgeControl_Internal(this Edge edge)
        {
            edge.ForceUpdateEdgeControl();
        }
    }

    public class Edge_Internals : Edge
    {
        public void UpdateEdgeControlColorsAndWidth_Internal() => UpdateEdgeControlColorsAndWidth();

        public Vector2 GetPortPosition_Internal(Port p) => GetPortPosition(p);

        public void TrackGraphElement_Internal(Port port) => TrackGraphElement(port);

        public void OnPortDetach_Internal(DetachFromPanelEvent e) => OnPortDetach(e);

        public void OnPortAttach_Internal(AttachToPanelEvent e) => OnPortAttach(e);

        public void OnEdgeAttach_Internal(AttachToPanelEvent e) => OnEdgeAttach(e);

        public void UntrackGraphElement_Internal(Port port) => UntrackGraphElement(port);

        public void DoTrackGraphElement_Internal(Port port) => DoTrackGraphElement(port);

        public void DoUntrackGraphElement_Internal(Port port) => DoUntrackGraphElement(port);

        public void OnPortGeometryChanged_Internal(GeometryChangedEvent evt) => OnPortGeometryChanged(evt);

        public void OnGeometryChanged_Internal(GeometryChangedEvent evt) => OnGeometryChanged(evt);

        public static bool Approximately_Internal(Vector2 v1, Vector2 v2) => Approximately(v1, v2);
    }
}