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
        public static int s_DefaultEdgeWidth_Internal => s_DefaultEdgeWidth;
        public static Color s_DefaultSelectedColor_Internal => s_DefaultSelectedColor;
        public static Color s_DefaultColor_Internal => s_DefaultColor;
        public static Color s_DefaultGhostColor_Internal => s_DefaultGhostColor;

        public int m_EdgeWidth_Internal
        {
            get => m_EdgeWidth;
            set => m_EdgeWidth = value;
        }

        public Color m_SelectedColor_Internal
        {
            get => m_SelectedColor;
            set => m_SelectedColor = value;
        }

        public Color m_DefaultColor_Internal
        {
            get => m_DefaultColor;
            set => m_DefaultColor = value;
        }

        public Color m_GhostColor_Internal
        {
            get => m_GhostColor;
            set => m_GhostColor = value;
        }

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