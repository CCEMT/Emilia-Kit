using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public class EdgeControl_Internals : EdgeControl
    {
        public bool renderPointsDirty_Internals
        {
            get => m_RenderPointsDirty;
            set => m_RenderPointsDirty = value;
        }

        public List<Vector2> renderPoints_Internals
        {
            get => m_RenderPoints;
            set => m_RenderPoints = value;
        }
    }
}