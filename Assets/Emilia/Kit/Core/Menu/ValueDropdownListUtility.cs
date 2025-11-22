using UnityEditor;
using UnityEngine;

namespace Emilia.Kit
{
    public static class ValueDropdownListUtility
    {
        public static ValueDropdownBuilder<T, string> GetScriptableObjectName<T>() where T : ScriptableObject
            => ValueDropdownListFactory.ScriptableObject<T, string>().WithSelector((x) => x.name);

        public static ValueDropdownBuilder<T, string> GetScriptableObjectName<T>(string path) where T : ScriptableObject
            => ValueDropdownListFactory.ScriptableObjectAtPath<T, string>(path).WithSelector((x) => x.name);
        
        public static ValueDropdownBuilder<T, string> GetScriptableObjectPath<T>() where T : ScriptableObject =>
            ValueDropdownListFactory.ScriptableObject<T, string>().WithSelector(AssetDatabase.GetAssetPath);

        public static ValueDropdownBuilder<T, string> GetAScriptableObjectPath<T>(string path) where T : ScriptableObject =>
            ValueDropdownListFactory.ScriptableObjectAtPath<T, string>(path).WithSelector(AssetDatabase.GetAssetPath);

        public static ValueDropdownBuilder<GameObject, string> GetPrefabName(string path)
            => ValueDropdownListFactory.Prefab<string>(path).WithSelector((x) => x.name);

        public static ValueDropdownBuilder<GameObject, string> GetPrefabPath(string path)
            => ValueDropdownListFactory.Prefab<string>(path).WithSelector(AssetDatabase.GetAssetPath);
    }
}