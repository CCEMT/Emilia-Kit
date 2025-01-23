using UnityEngine.UIElements;

namespace Emilia.Reflection.Editor
{
    public class TwoPaneSplitView_Internals : TwoPaneSplitView
    {
        public TwoPaneSplitView_Internals(int fixedPaneIndex, float fixedPaneStartDimension, TwoPaneSplitViewOrientation orientation)
        {
            this.Init(fixedPaneIndex, fixedPaneStartDimension, orientation);
        }

        public VisualElement dragLine_Internal => m_DragLine;
        public VisualElement dragLineAnchor_Internal => m_DragLineAnchor;
    }
}