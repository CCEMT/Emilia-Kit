using UnityEngine;
using UnityEngine.UIElements;

namespace Emilia.Reflection.Editor
{
    public static class VisualElementExtension_Internals
    {
        public static Matrix4x4 GetWorldTransformInverseCache_Internal(this VisualElement visualElement)
        {
            return visualElement.m_WorldTransformInverseCache;
        }
        
        public static Rect GetRect_Internal(this VisualElement visualElement)
        {
            return visualElement.rect;
        }

        public static bool isWorldTransformDirty_Internal(this VisualElement visualElement)
        {
            return visualElement.isWorldTransformDirty;
        }
        
        public static bool isWorldTransformInverseDirty_Internal(this VisualElement visualElement)
        {
            return visualElement.isWorldTransformInverseDirty;
        }
        
        public static void UpdateWorldTransformInverse_Internal(this VisualElement visualElement)
        {
            visualElement.UpdateWorldTransformInverse();
        }
        
        public static void SetLayout_Internals(this VisualElement visualElement, Rect layout)
        {
            visualElement.layout = layout;
        }

        public static void SendEvent_Internal(this VisualElement visualElement, EventBase e, DispatchMode_Internals mode)
        {
            visualElement.SendEvent(e, (DispatchMode) mode);
        }

        public static void ResetPositionProperties_Internal(this VisualElement visualElement)
        {
            visualElement.ResetPositionProperties();
        }

        public static void AddStyleSheetPath_Internal(this VisualElement visualElement, string path)
        {
            visualElement.AddStyleSheetPath(path);
        }
    }
}