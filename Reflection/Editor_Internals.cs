using System;
using UnityEditor;
using UnityEditor.U2D;

namespace Emilia.Reflection.Editor
{
    public static class Editor_Extensions
    {
        public static void OnHeaderGUI_Internals(this UnityEditor.Editor thisEditor)
        {
            thisEditor.OnHeaderGUI();
        }
    }

    public static class Editor_Internals
    {
        public static Type SpriteAtlasInspectorType_Internals = typeof(SpriteAtlasInspector);
        public static Type GameObjectInspectorType_Internals => typeof(GameObjectInspector);
        public static Type AnimationWindowEventInspectorType_Internals => typeof(AnimationWindowEventInspector);
        public static Type AudioClipInspectorType_Internals => typeof(AudioClipInspector);
        public static Type GenericInspectorType_Internals => typeof(GenericInspector);
        public static Type TextAssetInspector_Internals => typeof(TextAssetInspector);
        public static Type MonoScriptInspectorType_Internals => typeof(MonoScriptInspector);
        public static Type TransformInspectorType_Internals => typeof(TransformInspector);
        public static Type VideoClipInspectorType_Internals => typeof(VideoClipInspector);

        public static Type RectTransformEditorType_Internals => typeof(RectTransformEditor);
        public static Type AnimationClipEditorType_Internals => typeof(AnimationClipEditor);
        public static Type AnimationEditorType_Internals => typeof(AnimationEditor);
        public static Type VideoPlayerEditorType_Internals => typeof(VideoPlayerEditor);
    }
}