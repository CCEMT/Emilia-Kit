using System.Collections.Generic;
using UnityEditor;

namespace Emilia.Reflection.Editor
{
    public static class AssetDatabase_Internals
    {
        public static IEnumerable<HierarchyProperty> FindAllAssets_Internal(SearchFilter searchFilter) => AssetDatabase.FindAllAssets(searchFilter);

        public static IEnumerable<HierarchyProperty> FindAllAssets_Internal(SearchFilter_Internal searchFilter) => AssetDatabase.FindAllAssets(searchFilter);

        public static Dictionary<string, float> GetAllLabels_Internal() => AssetDatabase.GetAllLabels();

        public static int GetMainAssetInstanceID_Internal(string assetPath) => AssetDatabase.GetMainAssetInstanceID(assetPath);

        public static int GetMainAssetOrInProgressProxyInstanceID_Internal(string assetPath) => AssetDatabase.GetMainAssetOrInProgressProxyInstanceID(assetPath);
    }
}
