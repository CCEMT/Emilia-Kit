using UnityEditor;

namespace Emilia.Reflection.Editor
{
    public class TimeArea_Internals : TimeArea
    {
        public TimeArea_Internals(bool minimalGUI) : base(minimalGUI) { }
        public TimeArea_Internals(bool minimalGUI, bool enableSliderZoom) : base(minimalGUI, enableSliderZoom) { }
        public TimeArea_Internals(bool minimalGUI, bool enableSliderZoomHorizontal, bool enableSliderZoomVertical) : base(minimalGUI, enableSliderZoomHorizontal, enableSliderZoomVertical) { }
    }
}