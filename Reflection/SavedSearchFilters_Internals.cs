using UnityEditor;
using UnityEditor.IMGUI.Controls;

namespace Emilia.Reflection.Editor
{
    public static class SavedSearchFilters_Internals
    {
        public static bool IsSavedFilter_Internal(int instanceID) => SavedSearchFilters.IsSavedFilter(instanceID);

        public static int GetRootInstanceID_Internal() => SavedSearchFilters.GetRootInstanceID();

        public static SearchFilter GetFilter_Internal(int instanceID) => SavedSearchFilters.GetFilter(instanceID);

        public static string GetName_Internal(int instanceID) => SavedSearchFilters.GetName(instanceID);

        public static void RemoveSavedFilter_Internal(int instanceID) => SavedSearchFilters.RemoveSavedFilter(instanceID);

        public static bool TryApplyFilter_Internal(int instanceID, SearchFilter_Internal destination, out string displayName)
        {
            displayName = string.Empty;
            if (destination == null || !SavedSearchFilters.IsSavedFilter(instanceID))
                return false;

            SearchFilter filter = SavedSearchFilters.GetFilter(instanceID);
            if (filter == null)
                return false;

            destination.SetNewFilter_Internal(filter);
            displayName = SavedSearchFilters.GetName(instanceID) ?? string.Empty;
            return true;
        }

        public static TreeViewItem ConvertToTreeView_Internal() => SavedSearchFilters.ConvertToTreeView();
    }
}
