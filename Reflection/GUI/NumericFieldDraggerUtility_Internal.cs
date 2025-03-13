using UnityEditor;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public static class NumericFieldDraggerUtility_Internal
    {
        public static float Acceleration_Internal(bool shiftPressed, bool altPressed)
        {
            return NumericFieldDraggerUtility.Acceleration(shiftPressed, altPressed);
        }

        public static float NiceDelta_Internal(Vector2 deviceDelta, float acceleration)
        {
            return NumericFieldDraggerUtility.NiceDelta(deviceDelta, acceleration);
        }

        public static double CalculateFloatDragSensitivity_Internal(double value)
        {
            return NumericFieldDraggerUtility.CalculateFloatDragSensitivity(value);
        }

        public static long CalculateIntDragSensitivity_Internal(long value)
        {
            return NumericFieldDraggerUtility.CalculateIntDragSensitivity(value);
        }

        public static long CalculateIntDragSensitivity_Internal(long value, long minValue, long maxValue)
        {
            return NumericFieldDraggerUtility.CalculateIntDragSensitivity(value, minValue, maxValue);
        }
    }
}