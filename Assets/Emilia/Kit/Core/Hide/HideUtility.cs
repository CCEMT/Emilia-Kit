using System;
using UnityEngine;

namespace Emilia.Kit
{
    public static class HideUtility
    {
        public static bool IsHide(Type type)
        {
            return false;
        }

        public static bool IsHide(ScriptableObject scriptableObject)
        {
            return false;
        }

        public static bool IsHide(GameObject gameObject)
        {
            return false;
        }
        
        public static bool IsHide(object instance)
        {
            return false;
        }
    }
}