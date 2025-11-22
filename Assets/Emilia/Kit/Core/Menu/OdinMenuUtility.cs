using UnityEditor;
using UnityEngine;

namespace Emilia.Kit
{
    public static class OdinMenuUtility
    {
        public static OdinMenuBuilder<T, string> GetScriptableObjectName<T>() where T : ScriptableObject
            => OdinMenuFactory.ScriptableObject<T, string>().WithSelector((x) => x.name);

        public static OdinMenuBuilder<T, string> GetScriptableObjectName<T>(string path) where T : ScriptableObject
            => OdinMenuFactory.ScriptableObjectAtPath<T, string>(path).WithSelector((x) => x.name);

        public static OdinMenuBuilder<T, string> GetAScriptableObjectPath<T>() where T : ScriptableObject =>
            OdinMenuFactory.ScriptableObject<T, string>().WithSelector(AssetDatabase.GetAssetPath);

        public static OdinMenuBuilder<T, string> GetScriptableObjectPath<T>(string path) where T : ScriptableObject =>
            OdinMenuFactory.ScriptableObjectAtPath<T, string>(path).WithSelector(AssetDatabase.GetAssetPath);

        public static OdinMenuBuilder<GameObject, string> GetPrefabName(string path)
            => OdinMenuFactory.Prefab<string>(path).WithSelector((x) => x.name);

        public static OdinMenuBuilder<GameObject, string> GetPrefabPath(string path)
            => OdinMenuFactory.Prefab<string>(path).WithSelector(AssetDatabase.GetAssetPath);
    }
}