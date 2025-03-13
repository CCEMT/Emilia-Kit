using UnityEditor;

namespace Emilia.Reflection.Editor
{
    public static class NumericFieldDraggerUtility_Internal
    {
        public static double CalculateIntDragSensitivity_Internal(long value)
        {
            return NumericFieldDraggerUtility.CalculateIntDragSensitivity(value);
        }

        public static long CalculateIntDragSensitivity_Internal(long value, long minValue, long maxValue)
        {
            return NumericFieldDraggerUtility.CalculateIntDragSensitivity(value, minValue, maxValue);
        }
    }
}