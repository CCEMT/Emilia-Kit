using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public class Snapper_Internals : Snapper
    {
        public void BeginSnap_Internals(GraphView graphView)
        {
            BeginSnap(graphView);
        }

        public List<Rect> GetNotSelectedElementRectsInView_Internals() => GetNotSelectedElementRectsInView();

        public Rect GetSnappedRect_Internals(Rect sourceRect, float scale = 1.0f) => GetSnappedRect(sourceRect, 1);

        public void EndSnap_Internals(GraphView graphView)
        {
            EndSnap(graphView);
        }

        public void ClearSnapLines_Internals()
        {
            ClearSnapLines();
        }
    }
}