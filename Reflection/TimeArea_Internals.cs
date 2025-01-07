using UnityEditor;
using UnityEngine;

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

        public enum TimeRulerDragMode_Internals
        {
            None,
            Start,
            End,
            Dragging,
            Cancel,
        }

        public enum YDirection_Internals
        {
            Positive,
            Negative,
        }

        public int areaControlID_Internals
        {
            get => areaControlID;
            set => areaControlID = value;
        }

        public bool hRangeLocked_Internals
        {
            get => hRangeLocked;
            set => hRangeLocked = value;
        }

        public bool vRangeLocked_Internals
        {
            get => vRangeLocked;
            set => vRangeLocked = value;
        }

        public float hBaseRangeMin_Internals
        {
            get => hBaseRangeMin;
            set => hBaseRangeMin = value;
        }

        public float hBaseRangeMax_Internals
        {
            get => hBaseRangeMax;
            set => hBaseRangeMax = value;
        }

        public float vBaseRangeMin_Internals
        {
            get => vBaseRangeMin;
            set => vBaseRangeMin = value;
        }

        public float vBaseRangeMax_Internals
        {
            get => vBaseRangeMax;
            set => vBaseRangeMax = value;
        }

        public bool hAllowExceedBaseRangeMin_Internals
        {
            get => hAllowExceedBaseRangeMin;
            set => hAllowExceedBaseRangeMin = value;
        }

        public bool hAllowExceedBaseRangeMax_Internals
        {
            get => hAllowExceedBaseRangeMax;
            set => hAllowExceedBaseRangeMax = value;
        }

        public bool vAllowExceedBaseRangeMin_Internals
        {
            get => vAllowExceedBaseRangeMin;
            set => vAllowExceedBaseRangeMin = value;
        }

        public bool vAllowExceedBaseRangeMax_Internals
        {
            get => vAllowExceedBaseRangeMax;
            set => vAllowExceedBaseRangeMax = value;
        }

        public float hRangeMin_Internals
        {
            get => hRangeMin;
            set => hRangeMin = value;
        }

        public float hRangeMax_Internals
        {
            get => hRangeMax;
            set => hRangeMax = value;
        }

        public float vRangeMin_Internals
        {
            get => vRangeMin;
            set => vRangeMin = value;
        }

        public float vRangeMax_Internals
        {
            get => vRangeMax;
            set => vRangeMax = value;
        }

        public float minWidth_Internals
        {
            get => minWidth;
            set => minWidth = value;
        }

        public float hScaleMin_Internals
        {
            get => hScaleMin;
            set => hScaleMin = value;
        }

        public float hScaleMax_Internals
        {
            get => hScaleMax;
            set => hScaleMax = value;
        }

        public float vScaleMin_Internals
        {
            get => vScaleMin;
            set => vScaleMin = value;
        }

        public float vScaleMax_Internals
        {
            get => vScaleMax;
            set => vScaleMax = value;
        }

        public bool scaleWithWindow_Internals
        {
            get => scaleWithWindow;
            set => scaleWithWindow = value;
        }

        public bool hSlider_Internals
        {
            get => hSlider;
            set => hSlider = value;
        }

        public bool vSlider_Internals
        {
            get => vSlider;
            set => vSlider = value;
        }

        public bool ignoreScrollWheelUntilClicked_Internals
        {
            get => ignoreScrollWheelUntilClicked;
            set => ignoreScrollWheelUntilClicked = value;
        }

        public bool enableMouseInput_Internals
        {
            get => enableMouseInput;
            set => enableMouseInput = value;
        }

        public bool allowSliderZoomHorizontal_Internals => allowSliderZoomHorizontal;

        protected bool allowSliderZoomVertical_Internals => allowSliderZoomVertical;

        public bool uniformScale_Internals
        {
            get => uniformScale;
            set => uniformScale = value;
        }

        public YDirection_Internals upDirection_Internals
        {
            get => (YDirection_Internals) upDirection;
            set => upDirection = (YDirection) value;
        }

        public void SetDrawRectHack_Internals(Rect r)
        {
            SetDrawRectHack(r);
        }

        public Vector2 scale_Internals
        {
            get => this.m_Scale;
            set => this.m_Scale = value;
        }

        public Vector2 translation_Internals
        {
            get => this.m_Translation;
            set => this.m_Translation = value;
        }

        public float margin_Internals
        {
            set => margin = value;
        }

        public float leftmargin_Internals
        {
            get => leftmargin;
            set => leftmargin = value;
        }

        public float rightmargin_Internals
        {
            get => rightmargin;
            set => rightmargin = value;
        }

        public float topmargin_Internals
        {
            get => topmargin;
            set => topmargin = value;
        }

        public float bottommargin_Internals
        {
            get => bottommargin;
            set => bottommargin = value;
        }

        public float vSliderWidth_Internals => vSliderWidth;

        public float hSliderHeight_Internals => hSliderHeight;

        public Rect rect_Internals
        {
            get => rect;
            set => rect = value;
        }

        public Rect drawRect_Internals => drawRect;

        public void SetShownHRangeInsideMargins_Internals(float min, float max)
        {
            SetShownHRangeInsideMargins(min, max);
        }

        public void SetShownHRange_Internals(float min, float max)
        {
            SetShownHRange(min, max);
        }

        public void SetShownVRangeInsideMargins_Internals(float min, float max)
        {
            SetShownVRangeInsideMargins(min, max);
        }

        public void SetShownVRange_Internals(float min, float max)
        {
            SetShownVRange(min, max);
        }

        public Rect shownArea_Internals
        {
            get => shownArea;
            set => shownArea = value;
        }

        public Rect shownAreaInsideMargins_Internals
        {
            get => shownAreaInsideMargins;
            set => shownAreaInsideMargins = value;
        }

        public Matrix4x4 drawingToViewMatrix_Internals => drawingToViewMatrix;

        public Vector2 DrawingToViewTransformPoint_Internals(Vector2 lhs)
        {
            return DrawingToViewTransformPoint(lhs);
        }

        public Vector3 DrawingToViewTransformPoint_Internals(Vector3 lhs)
        {
            return DrawingToViewTransformPoint(lhs);
        }

        public Vector2 ViewToDrawingTransformPoint_Internals(Vector2 lhs)
        {
            return ViewToDrawingTransformPoint(lhs);
        }

        public Vector3 ViewToDrawingTransformPoint_Internals(Vector3 lhs)
        {
            return ViewToDrawingTransformPoint(lhs);
        }

        public Vector2 DrawingToViewTransformVector_Internals(Vector2 lhs)
        {
            return DrawingToViewTransformVector(lhs);
        }

        public Vector3 DrawingToViewTransformVector_Internals(Vector3 lhs)
        {
            return DrawingToViewTransformVector(lhs);
        }

        public Vector2 ViewToDrawingTransformVector_Internals(Vector2 lhs)
        {
            return ViewToDrawingTransformVector(lhs);
        }

        public Vector3 ViewToDrawingTransformVector_Internals(Vector3 lhs)
        {
            return ViewToDrawingTransformVector(lhs);
        }

        public Vector2 mousePositionInDrawing_Internals => mousePositionInDrawing;

        public Vector2 NormalizeInViewSpace_Internals(Vector2 vec)
        {
            return NormalizeInViewSpace(vec);
        }

        public TimeArea_Internals(bool minimalGUI) : base(minimalGUI) { }
        public TimeArea_Internals(bool minimalGUI, bool enableSliderZoom) : base(minimalGUI, enableSliderZoom) { }
        public TimeArea_Internals(bool minimalGUI, bool enableSliderZoomHorizontal, bool enableSliderZoomVertical) : base(minimalGUI, enableSliderZoomHorizontal, enableSliderZoomVertical) { }

        public void SetTickMarkerRanges_Internals()
        {
            base.SetTickMarkerRanges();
        }

        public void DrawMajorTicks_Internals(Rect position, float frameRate)
        {
            base.DrawMajorTicks(position, frameRate);
        }

        public void TimeRuler_Internals(Rect position, float frameRate)
        {
            base.TimeRuler(position, frameRate);
        }

        public void TimeRuler_Internals(Rect position,
            float frameRate,
            bool labels,
            bool useEntireHeight,
            float alpha,
            TimeFormat_Internals timeFormatInternals)
        {
            base.TimeRuler(position, frameRate, labels, useEntireHeight, alpha, (TimeFormat) timeFormatInternals);
        }

        public static void DrawPlayhead_Internals(float x, float yMin, float yMax, float thickness, float alpha)
        {
            DrawPlayhead(x, yMin, yMax, thickness, alpha);
        }

        public static void DrawVerticalLine_Internals(float x, float minY, float maxY, Color color)
        {
            DrawVerticalLine(x, minY, maxY, color);
        }

        public static void DrawVerticalLineFast_Internals(float x, float minY, float maxY, Color color)
        {
            DrawVerticalLineFast(x, minY, maxY, color);
        }

        public TimeRulerDragMode_Internals BrowseRuler_Internals(Rect position, ref float time, float frameRate, bool pickAnywhere, GUIStyle thumbStyle)
        {
            return (TimeRulerDragMode_Internals) BrowseRuler(position, ref time, frameRate, pickAnywhere, thumbStyle);
        }

        public TimeRulerDragMode_Internals BrowseRuler_Internals(Rect position, int id, ref float time, float frameRate, bool pickAnywhere, GUIStyle thumbStyle)
        {
            return (TimeRulerDragMode_Internals) BrowseRuler(position, id, ref time, frameRate, pickAnywhere, thumbStyle);
        }

        public float FrameToPixel_Internals(float i, float frameRate, Rect rect)
        {
            return this.FrameToPixel(i, frameRate, rect, this.shownArea);
        }

        public float TimeField_Internals(Rect rect, int id, float time, float frameRate, TimeFormat_Internals timeFormat)
        {
            return TimeField(rect, id, time, frameRate, (TimeFormat) timeFormat);
        }

        public float ValueField_Internals(Rect rect, int id, float value)
        {
            return ValueField(rect, id, value);
        }

        public string FormatTime_Internals(float time, float frameRate, TimeFormat_Internals timeFormat)
        {
            return base.FormatTickTime(time, frameRate, (TimeFormat) timeFormat);
        }

        public override string FormatTickTime(float time, float frameRate, TimeFormat timeFormat)
        {
            return FormatTickTime_Internals(time, frameRate, (TimeFormat_Internals) timeFormat);
        }

        public virtual string FormatTickTime_Internals(float time, float frameRate, TimeFormat_Internals timeFormat)
        {
            return base.FormatTickTime(time, frameRate, (TimeFormat) timeFormat);
        }

        public string FormatValue_Internals(float value)
        {
            return base.FormatValue(value);
        }

        public float SnapTimeToWholeFPS_Internals(float time, float frameRate)
        {
            return base.SnapTimeToWholeFPS(time, frameRate);
        }

        public void DrawTimeOnSlider_Internals(float time, Color c, float maxTime, float leftSidePadding = 0.0f, float rightSidePadding = 0.0f)
        {
            base.DrawTimeOnSlider(time, c, maxTime, leftSidePadding, rightSidePadding);
        }

        public void BeginViewGUI_Internals()
        {
            base.BeginViewGUI();
        }

        public void EndViewGUI_Internals()
        {
            base.EndViewGUI();
        }

        public void HandleZoomAndPanEvents_Internals(Rect area)
        {
            base.HandleZoomAndPanEvents(area);
        }

        public void SetScaleFocused_Internals(Vector2 focalPoint, Vector2 newScale)
        {
            base.SetScaleFocused(focalPoint, newScale);
        }

        public void SetScaleFocused_Internals(Vector2 focalPoint, Vector2 newScale, bool lockHorizontal, bool lockVertical)
        {
            base.SetScaleFocused(focalPoint, newScale, lockHorizontal, lockVertical);
        }

        public void SetTransform_Internals(Vector2 newTranslation, Vector2 newScale)
        {
            base.SetTransform(newTranslation, newScale);
        }

        public void EnforceScaleAndRange_Internals()
        {
            base.EnforceScaleAndRange();
        }

        public float PixelToTime_Internals(float pixelX, Rect rect)
        {
            return base.PixelToTime(pixelX, rect);
        }

        public float TimeToPixel_Internals(float time, Rect rect)
        {
            return base.TimeToPixel(time, rect);
        }

        public float PixelDeltaToTime_Internals(Rect rect)
        {
            return base.PixelDeltaToTime(rect);
        }

        public void UpdateZoomScale_Internals(float fMaxScaleValue, float fMinScaleValue)
        {
            base.UpdateZoomScale(fMaxScaleValue, fMinScaleValue);
        }
    }
}