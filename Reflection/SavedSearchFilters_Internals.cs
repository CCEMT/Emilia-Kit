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

        public static TreeViewItem ConvertToTreeView_Internal() => SavedSearchFilters.ConvertToTreeView();
    }
}