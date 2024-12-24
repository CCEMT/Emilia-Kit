#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using System.IO;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Emilia.Kit
{
    public static class EditorAssetKit
    {
        public static string dataParentPath => Directory.GetParent(Application.dataPath).ToString();

        public static T[] GetEditorResources<T>() where T : Object
        {
            string typeSearchString = $" t:{typeof(T).Name}";
            string[] guids = AssetDatabase.FindAssets(typeSearchString);
            T[] preferences = new T[guids.Length];
            for (int i = 0; i < guids.Length; i++)
            {
                string path = AssetDatabase.GUIDToAssetPath(guids[i]);
                preferences[i] = AssetDatabase.LoadAssetAtPath<T>(path);
            }
            return preferences;
        }

        public static Object[] GetEditorResources(Type type)
        {
            string typeSearchString = $" t:{type.Name}";
            string[] guids = AssetDatabase.FindAssets(typeSearchString);
            Object[] preferences = new Object[guids.Length];
            for (int i = 0; i < guids.Length; i++)
            {
                string path = AssetDatabase.GUIDToAssetPath(guids[i]);
                preferences[i] = AssetDatabase.LoadAssetAtPath<Object>(path);
            }
            return preferences;
        }

        public static List<T> GetEditorResources<T>(string pathFilter) where T : Object
        {
            string typeSearchString = $" t:{typeof(T).Name}";
            string[] guids = AssetDatabase.FindAssets(typeSearchString);
            List<T> preferences = new List<T>();
            for (int i = 0; i < guids.Length; i++)
            {
                string path = AssetDatabase.GUIDToAssetPath(guids[i]);
                if (path.Contains(pathFilter) == false) continue;
                preferences.Add(AssetDatabase.LoadAssetAtPath<T>(path));
            }
            return preferences;
        }

        public static void SaveAssetIntoObject(Object childAsset, Object masterAsset)
        {
            if (childAsset == null || masterAsset == null) return;

            if ((masterAsset.hideFlags & HideFlags.DontSave) != 0) childAsset.hideFlags |= HideFlags.DontSave;
            else
            {
                childAsset.hideFlags |= HideFlags.HideInHierarchy;
                if (! AssetDatabase.Contains(childAsset) && AssetDatabase.Contains(masterAsset)) AssetDatabase.AddObjectToAsset(childAsset, masterAsset);
            }
        }

        public static T CreateAsset<T>(string path) where T : ScriptableObject
        {
            T asset = ScriptableObject.CreateInstance<T>();
            AssetDatabase.CreateAsset(asset, path);
            return asset;
        }

        public static bool DeleteAsset(Object target)
        {
            if (target == default) return false;
            string path = AssetDatabase.GetAssetPath(target);
            return AssetDatabase.DeleteAsset(path);
        }

        public static GameObject GetPrefabAsset(GameObject gameObject)
        {
            if (gameObject == null) return null;
            if (PrefabUtility.IsPartOfPrefabAsset(gameObject)) return gameObject;
            PrefabStage prefabStage = PrefabStageUtility.GetPrefabStage(gameObject);
            if (prefabStage != null) return prefabStage.prefabContentsRoot;
            if (PrefabUtility.IsPartOfPrefabInstance(gameObject)) return PrefabUtility.GetCorrespondingObjectFromOriginalSource(gameObject);
            return null;
        }
    }
}
#endif