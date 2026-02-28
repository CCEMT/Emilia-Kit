using UnityEditor;

namespace Emilia.Reflection.Editor
{
    public class SearchFilter_Internal : SearchFilter
    {
        public enum SearchArea_Internal
        {
            AllAssets,
            InAssetsOnly,
            InPackagesOnly,
            SelectedFolders,
        }

        public enum State_Internal
        {
            EmptySearchFilter,
            FolderBrowsing,
            SearchingInAllAssets,
            SearchingInAssetsOnly,
            SearchingInPackagesOnly,
            SearchingInFolders,
        }

        public string nameFilter_Internal
        {
            get => this.m_NameFilter;
            set => this.m_NameFilter = value;
        }

        public string[] classNames_Internal
        {
            get => this.m_ClassNames;
            set => this.m_ClassNames = value;
        }

        public string[] assetLabels_Internal
        {
            get => this.m_AssetLabels;
            set => this.m_AssetLabels = value;
        }

        public string[] assetBundleNames_Internal
        {
            get => this.m_AssetBundleNames;
            set => this.m_AssetBundleNames = value;
        }

        public int[] referencingInstanceIDs_Internal
        {
            get => this.m_ReferencingInstanceIDs;
            set => this.m_ReferencingInstanceIDs = value;
        }

        public int[] sceneHandles_Internal
        {
            get => this.m_SceneHandles;
            set => this.m_SceneHandles = value;
        }

        public bool showAllHits_Internal
        {
            get => this.m_ShowAllHits;
            set => this.m_ShowAllHits = value;
        }

        public bool skipHidden_Internal
        {
            get => this.m_SkipHidden;
            set => this.m_SkipHidden = value;
        }

        public string[] folders_Internal
        {
            get => this.m_Folders;
            set => this.m_Folders = value;
        }

        public SearchArea_Internal searchArea_Internal
        {
            get => (SearchArea_Internal) this.m_SearchArea;
            set => this.m_SearchArea = (SearchArea) value;
        }

        public string[] globs_Internal
        {
            get => this.m_Globs;
            set => this.m_Globs = value;
        }

        public string originalText_Internal
        {
            get => this.m_OriginalText;
            set => this.m_OriginalText = value;
        }

        public bool filterByTypeIntersection_Internal
        {
            get => this.m_FilterByTypeIntersection;
            set => this.m_FilterByTypeIntersection = value;
        }

        public void ClearSearch_Internal()
        {
            ClearSearch();
        }

        public State_Internal GetState_Internal() => (State_Internal) GetState();

        public bool IsSearching_Internal() => IsSearching();

        public bool SetNewFilter_Internal(SearchFilter_Internal newFilter) => SetNewFilter(newFilter);

        public string FilterToSearchFieldString_Internal() => FilterToSearchFieldString();

        public void SearchFieldStringToFilter_Internal(string searchFieldString)
        {
            SearchFieldStringToFilter(searchFieldString);
        }

        public static SearchFilter_Internal CreateSearchFilterFromString_Internal(string searchFieldString)
        {
            SearchFilter_Internal searchFilterInternal = new SearchFilter_Internal();
            SearchUtility.ParseSearchString(searchFieldString, searchFilterInternal);
            return searchFilterInternal;
        }

        public static string[] Split_Internal(string text) => Split(text);
    }
}