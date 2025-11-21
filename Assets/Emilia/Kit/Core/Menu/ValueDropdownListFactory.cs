#if UNITY_EDITOR
using UnityEngine;
using Object = UnityEngine.Object;

namespace Emilia.Kit
{
    public static class ValueDropdownListFactory
    {
        public static DropdownBuilder<T1, T2> ScriptableObject<T1, T2>() where T1 : ScriptableObject
        {
            return new DropdownBuilder<T1, T2>()
                .WithResources(EditorAssetKit.GetEditorResources<T1>())
                .WithDescription((x) => ObjectDescriptionUtility.GetDescription(x));
        }

        public static DropdownBuilder<T1, T2> ScriptableObjectAtPath<T1, T2>(string path) where T1 : ScriptableObject
        {
            return new DropdownBuilder<T1, T2>()
                .WithResources(EditorAssetKit.LoadAssetAtPath<T1>(path))
                .WithDescription((x) => ObjectDescriptionUtility.GetDescription(x));
        }

        public static DropdownBuilder<GameObject, T> Prefab<T>(string path) =>
            new DropdownBuilder<GameObject, T>()
                .WithResources(EditorAssetKit.LoadAtPath<GameObject>(path, "*.prefab"))
                .WithDescription(PrefabDefaultDescription);

        public static DropdownBuilder<T1, T2> Asset<T1, T2>(string path, string searchPattern) where T1 : Object
        {
            return new DropdownBuilder<T1, T2>()
                .WithResources(EditorAssetKit.LoadAtPath<T1>(path, searchPattern))
                .WithDescription((x) => ObjectDescriptionUtility.GetDescription(x));
        }

        private static string PrefabDefaultDescription(GameObject prefab)
        {
            IObjectDescription descriptionComponent = prefab != null ? prefab.GetComponent<IObjectDescription>() : null;
            return descriptionComponent != null ? descriptionComponent.description : string.Empty;
        }
    }
}
#endif