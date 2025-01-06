using UnityEditor;

namespace Emilia.Reflection.Editor
{
    public class TimeArea_Internals : TimeArea
    {
        public enum TimeFormat_Internals
        {
            None,
            TimeFrame,
            Frame,
        }

        public TimeArea_Internals(bool minimalGUI) : base(minimalGUI) { }
        public TimeArea_Internals(bool minimalGUI, bool enableSliderZoom) : base(minimalGUI, enableSliderZoom) { }
        public TimeArea_Internals(bool minimalGUI, bool enableSliderZoomHorizontal, bool enableSliderZoomVertical) : base(minimalGUI, enableSliderZoomHorizontal, enableSliderZoomVertical) { }

        public override string FormatTickTime(float time, float frameRate, TimeFormat timeFormat)
        {
            return FormatTickTime_Internals(time, frameRate, (TimeFormat_Internals) timeFormat);
        }

        public virtual string FormatTickTime_Internals(float time, float frameRate, TimeFormat_Internals timeFormat)
        {
            return base.FormatTickTime(time, frameRate, (TimeFormat) timeFormat);
        }

        public string FormatTime_Internals(float time, float frameRate, TimeFormat_Internals timeFormat)
        {
            return base.FormatTickTime(time, frameRate, (TimeFormat) timeFormat);
        }
    }
}