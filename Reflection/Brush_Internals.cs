using UnityEditor;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public struct Brush_Internal
    {
        private Brush _brush;

        internal Brush Target_Internal => _brush;
        
        public ScriptableObject brushObject_Internal => _brush;

        public bool isValid_Internal => _brush != null;

        public static float kMaxRadiusScale_Internal => Brush.kMaxRadiusScale;

        public static Material s_CreateBrushMaterial_Internal
        {
            get => Brush.s_CreateBrushMaterial;
            set => Brush.s_CreateBrushMaterial = value;
        }

        public static Texture2D s_WhiteTexture_Internal
        {
            get => Brush.s_WhiteTexture;
            set => Brush.s_WhiteTexture = value;
        }

        public static float sqrt2_Internal => Brush.sqrt2;

        public float m_BlackWhiteRemapMax_Internal
        {
            get => _brush.m_BlackWhiteRemapMax;
            set => _brush.m_BlackWhiteRemapMax = value;
        }

        public float m_BlackWhiteRemapMin_Internal
        {
            get => _brush.m_BlackWhiteRemapMin;
            set => _brush.m_BlackWhiteRemapMin = value;
        }

        public AnimationCurve m_Falloff_Internal
        {
            get => _brush.m_Falloff;
            set => _brush.m_Falloff = value;
        }

        public bool m_InvertRemapRange_Internal
        {
            get => _brush.m_InvertRemapRange;
            set => _brush.m_InvertRemapRange = value;
        }

        public Texture2D m_Mask_Internal
        {
            get => _brush.m_Mask;
            set => _brush.m_Mask = value;
        }

        public float m_RadiusScale_Internal
        {
            get => _brush.m_RadiusScale;
            set => _brush.m_RadiusScale = value;
        }

        public Texture2D m_Texture_Internal
        {
            get => _brush.m_Texture;
            set => _brush.m_Texture = value;
        }

        public Texture2D m_Thumbnail_Internal
        {
            get => _brush.m_Thumbnail;
            set => _brush.m_Thumbnail = value;
        }

        public bool m_UpdateTexture_Internal
        {
            get => _brush.m_UpdateTexture;
            set => _brush.m_UpdateTexture = value;
        }

        public bool m_UpdateThumbnail_Internal
        {
            get => _brush.m_UpdateThumbnail;
            set => _brush.m_UpdateThumbnail = value;
        }

        public bool readOnly_Internal => _brush.readOnly;

        public Texture2D texture_Internal => _brush.texture;

        public Texture2D thumbnail_Internal => _brush.thumbnail;

        public Brush_Internal(Brush brush)
        {
            _brush = brush;
        }

        public void Reset_Internal()
        {
            _brush.Reset();
        }

        public void SetDirty_Internal(bool isDirty)
        {
            _brush.SetDirty(isDirty);
        }

        public void UpdateTexture_Internal()
        {
            _brush.UpdateTexture();
        }

        public void UpdateThumbnail_Internal()
        {
            _brush.UpdateThumbnail();
        }
    }

    public static class Brush_Internals
    {
        public static Brush_Internal CreateInstance_Internal(Texture2D texture, AnimationCurve falloff, float radiusScale, bool isReadOnly) =>
            new Brush_Internal(Brush.CreateInstance(texture, falloff, radiusScale, isReadOnly));

        public static void CreateNewDefaultBrush_Internal()
        {
            Brush.CreateNewDefaultBrush();
        }

        public static Texture2D DefaultMask_Internal() => Brush.DefaultMask();

        public static Texture2D GenerateBrushTexture_Internal(
            Texture2D mask,
            AnimationCurve falloff,
            float radiusScale,
            float blackWhiteRemapMin,
            float blackWhiteRemapMax,
            bool invertRemapRange,
            int width,
            int height,
            bool isThumbnail)
        {
            return Brush.GenerateBrushTexture(mask, falloff, radiusScale, blackWhiteRemapMin, blackWhiteRemapMax, invertRemapRange, width, height, isThumbnail);
        }
    }
}
