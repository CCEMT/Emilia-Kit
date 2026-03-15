using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public struct FilteredHierarchyFilterResult_Internal
    {
        private FilteredHierarchy.FilterResult _result;

        internal FilteredHierarchy.FilterResult Target_Internal => _result;

        public bool isValid_Internal => _result != null;

        public int colorCode_Internal
        {
            get => _result.colorCode;
            set => _result.colorCode = value;
        }

        public bool hasChildren_Internal
        {
            get => _result.hasChildren;
            set => _result.hasChildren = value;
        }

        public bool hasFullPreviewImage_Internal
        {
            get => _result.hasFullPreviewImage;
            set => _result.hasFullPreviewImage = value;
        }

        public object iconDrawStyle_Internal
        {
            get => _result.iconDrawStyle;
            set => _result.iconDrawStyle = (IconDrawStyle) value;
        }

        public int instanceID_Internal
        {
            get => _result.instanceID;
            set => _result.instanceID = value;
        }

        public bool isFolder_Internal
        {
            get => _result.isFolder;
            set => _result.isFolder = value;
        }

        public bool isMainRepresentation_Internal
        {
            get => _result.isMainRepresentation;
            set => _result.isMainRepresentation = value;
        }

        public string m_Guid_Internal
        {
            get => _result.m_Guid;
            set => _result.m_Guid = value;
        }

        public Texture2D m_Icon_Internal
        {
            get => _result.m_Icon;
            set => _result.m_Icon = value;
        }

        public string name_Internal
        {
            get => _result.name;
            set => _result.name = value;
        }

        public HierarchyType type_Internal
        {
            get => _result.type;
            set => _result.type = value;
        }

        public string guid_Internal => _result.guid;

        public Texture2D icon_Internal => _result.icon;

        public FilteredHierarchyFilterResult_Internal(FilteredHierarchy.FilterResult result)
        {
            _result = result;
        }
    }

    public struct FilteredHierarchy_Internal
    {
        private FilteredHierarchy _filteredHierarchy;

        internal FilteredHierarchy Target_Internal => _filteredHierarchy;

        public bool isValid_Internal => _filteredHierarchy != null;

        public static int maxSearchAddCount_Internal => FilteredHierarchy.maxSearchAddCount;

        public HierarchyType m_HierarchyType_Internal
        {
            get => _filteredHierarchy.m_HierarchyType;
            set => _filteredHierarchy.m_HierarchyType = value;
        }

        public FilteredHierarchyFilterResult_Internal[] m_Results_Internal
        {
            get => WrapResults(_filteredHierarchy.m_Results);
            set => _filteredHierarchy.m_Results = UnwrapResults(value);
        }

        public SearchFilter m_SearchFilter_Internal
        {
            get => _filteredHierarchy.m_SearchFilter;
            set => _filteredHierarchy.m_SearchFilter = value;
        }

        public SearchSessionOptions_Internal m_SearchSessionOptions_Internal
        {
            get => new SearchSessionOptions_Internal(_filteredHierarchy.m_SearchSessionOptions);
            set => _filteredHierarchy.m_SearchSessionOptions = value.Target_Internal;
        }

        public FilteredHierarchyFilterResult_Internal[] m_VisibleItems_Internal
        {
            get => WrapResults(_filteredHierarchy.m_VisibleItems);
            set => _filteredHierarchy.m_VisibleItems = UnwrapResults(value);
        }

        public bool foldersFirst_Internal
        {
            get => _filteredHierarchy.foldersFirst;
            set => _filteredHierarchy.foldersFirst = value;
        }

        public HierarchyType hierarchyType_Internal => _filteredHierarchy.hierarchyType;

        public FilteredHierarchyFilterResult_Internal[] results_Internal => WrapResults(_filteredHierarchy.results);

        public SearchFilter searchFilter_Internal
        {
            get => _filteredHierarchy.searchFilter;
            set => _filteredHierarchy.searchFilter = value;
        }

        public FilteredHierarchy_Internal(FilteredHierarchy filteredHierarchy)
        {
            _filteredHierarchy = filteredHierarchy;
        }

        public FilteredHierarchy_Internal(HierarchyType hierarchyType)
        {
            _filteredHierarchy = new FilteredHierarchy(hierarchyType);
        }

        public FilteredHierarchy_Internal(HierarchyType hierarchyType, SearchSessionOptions_Internal searchSessionOptions)
        {
            _filteredHierarchy = new FilteredHierarchy(hierarchyType, searchSessionOptions.Target_Internal);
        }

        public void RefreshVisibleItems_Internal(List<int> expandedInstanceIDs)
        {
            _filteredHierarchy.RefreshVisibleItems(expandedInstanceIDs);
        }

        public List<int> GetSubAssetInstanceIDs_Internal(int mainAssetInstanceID) => _filteredHierarchy.GetSubAssetInstanceIDs(mainAssetInstanceID);

        public void ResultsChanged_Internal()
        {
            _filteredHierarchy.ResultsChanged();
        }

        public void SetResults_Internal(int[] instanceIDs)
        {
            _filteredHierarchy.SetResults(instanceIDs);
        }

        public void SetResults_Internal(int[] instanceIDs, string[] rootPaths)
        {
            _filteredHierarchy.SetResults(instanceIDs, rootPaths);
        }

        private static FilteredHierarchyFilterResult_Internal[] WrapResults(FilteredHierarchy.FilterResult[] results)
        {
            if (results == null)
                return null;

            FilteredHierarchyFilterResult_Internal[] wrapped = new FilteredHierarchyFilterResult_Internal[results.Length];
            for (int i = 0; i < results.Length; i++)
                wrapped[i] = new FilteredHierarchyFilterResult_Internal(results[i]);
            return wrapped;
        }

        private static FilteredHierarchy.FilterResult[] UnwrapResults(FilteredHierarchyFilterResult_Internal[] results)
        {
            if (results == null)
                return null;

            FilteredHierarchy.FilterResult[] unwrapped = new FilteredHierarchy.FilterResult[results.Length];
            for (int i = 0; i < results.Length; i++)
                unwrapped[i] = results[i].Target_Internal;
            return unwrapped;
        }
    }
}
