using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public static class GUIUtility_Internals
    {
        public static float RoundToPixelGrid_Internals(float value) => GUIUtility.RoundToPixelGrid(value);

        public static int GetPermanentControlID_Internals() => GUIUtility.GetPermanentControlID();
    }
}