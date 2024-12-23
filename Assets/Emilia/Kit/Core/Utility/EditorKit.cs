#if UNITY_EDITOR
using System;
using Sirenix.OdinInspector;
using Sirenix.Serialization;
using UnityEditor;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Emilia.Kit
{
    public static class EditorKit
    {
        public static void UnityInvoke(Action action)
        {
            bool waitFrameEnd = false;

            EditorApplication.update += Invoke;

            void Invoke()
            {
                if (waitFrameEnd == false)
                {
                    waitFrameEnd = true;
                    return;
                }

                action?.Invoke();
                EditorApplication.update -= Invoke;
            }
        }

        public static void Save(this Object target, bool isRefresh = false)
        {
            EditorUtility.SetDirty(target);
            AssetDatabase.SaveAssets();
            if (isRefresh) AssetDatabase.Refresh();
        }

        public static void SetSelection(object target, string disposeName = null)
        {
            if (string.IsNullOrEmpty(disposeName)) disposeName = target.ToString();
            SelectionContainer selectionContainer = ScriptableObject.CreateInstance<SelectionContainer>();
            selectionContainer.target = target;
            selectionContainer.displayName = disposeName;
            Selection.activeObject = selectionContainer;
        }

        [HideMonoScript]
        private class SelectionContainer : TitleAsset
        {
            [HideInInspector, SerializeField]
            public string displayName;

            [NonSerialized, OdinSerialize, HideReferenceObjectPicker, HideLabel]
            public object target;

            public override string title => displayName;
        }
    }
}
#endif