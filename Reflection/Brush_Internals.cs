using UnityEditor;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public static class Brush_Internals
    {
        public static Brush CreateInstance_Internal(Texture2D texture, AnimationCurve falloff, float radiusScale, bool isReadOnly) =>
            Brush.CreateInstance(texture, falloff, radiusScale, isReadOnly);
    }
}
