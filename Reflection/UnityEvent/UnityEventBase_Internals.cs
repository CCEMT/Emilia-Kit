using System;
using UnityEngine.Events;
using Object = UnityEngine.Object;

namespace Emilia.Reflection.Editor
{
    public static class UnityEventBase_Extensions
    {
        public static void RegisterVoidPersistentListenerWithoutValidation_Internals(
            this UnityEventBase thisUnityEventBase,
            int index,
            Object target,
            Type targetType,
            string methodName)
        {
            thisUnityEventBase.RegisterVoidPersistentListenerWithoutValidation(index, target, targetType, methodName);
        }
    }
}