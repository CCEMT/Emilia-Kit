﻿#if UNITY_EDITOR
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Emilia.Kit.Editor
{
    public static class IUnityAssetExtension
    {
        public static void SaveAll(this IUnityAsset unityAsset)
        {
            List<Object> allAsset = new List<Object>();
            unityAsset.CollectAsset(allAsset);

            int count = allAsset.Count;
            for (int i = 0; i < count; i++)
            {
                Object asset = allAsset[i];
                EditorUtility.SetDirty(asset);
            }

            AssetDatabase.SaveAssets();
        }

        public static void PasteChild(this IUnityAsset asset)
        {
            List<Object> pasteList = new List<Object>();
            List<Object> childAssets = asset.GetChildren();
            int amount = childAssets.Count;
            for (int i = 0; i < amount; i++)
            {
                Object child = childAssets[i];
                if (child == null) continue;
                Object pasteChild = Object.Instantiate(child);
                pasteChild.name = child.name;

                Undo.RegisterCreatedObjectUndo(pasteChild, "Paste");

                IUnityAsset childAsset = pasteChild as IUnityAsset;
                if (childAsset != null) PasteChild(childAsset);

                pasteList.Add(pasteChild);
            }

            asset.SetChildren(pasteList);
        }
    }
}
#endif