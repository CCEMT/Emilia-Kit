using UnityEngine.Events;

namespace Emilia.Reflection.Editor
{
    public static class UnityEvent_Extensions
    {
        public static void AddPersistentListener_Internals(this UnityEngine.Events.UnityEvent thisUnityEventBase, UnityAction call)
        {
            thisUnityEventBase.AddPersistentListener(call);
        }

        public static void AddPersistentListener_Internals<T0>(this UnityEvent<T0> thisUnityEventBase, UnityAction<T0> call)
        {
            thisUnityEventBase.AddPersistentListener(call);
        }

        public static void AddPersistentListener_Internals<T0, T1>(this UnityEvent<T0, T1> thisUnityEventBase, UnityAction<T0, T1> call)
        {
            thisUnityEventBase.AddPersistentListener(call);
        }

        public static void AddPersistentListener_Internals<T0, T1, T2>(this UnityEvent<T0, T1, T2> thisUnityEventBase, UnityAction<T0, T1, T2> call)
        {
            thisUnityEventBase.AddPersistentListener(call);
        }

        public static void AddPersistentListener_Internals<T0, T1, T2, T3>(this UnityEvent<T0, T1, T2, T3> thisUnityEventBase, UnityAction<T0, T1, T2, T3> call)
        {
            thisUnityEventBase.AddPersistentListener(call);
        }
    }
}