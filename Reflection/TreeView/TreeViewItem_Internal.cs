using UnityEditor;
using UnityEditor.IMGUI.Controls;

namespace Emilia.Reflection.Editor
{
    public static class TreeViewItem_Internal
    {
        public static bool TryGetIsEmpty_Internal(this TreeViewItem item, out bool isEmpty)
        {
            isEmpty = false;
            if (item == null) return false;

            if (item is AssetsTreeViewDataSource.FolderTreeItemBase folderItem == false)
                return false;

            isEmpty = folderItem.IsEmpty;
            return true;
        }
    }
}
