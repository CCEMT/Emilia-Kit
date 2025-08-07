using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public interface ITreeViewDataSource_Internal : ITreeViewDataSource
    {
        void OnInitialize_Internal();

        TreeViewItem root_Internal { get; }

        int rowCount_Internal { get; }

        void ReloadData_Internal();

        void InitIfNeeded_Internal();

        TreeViewItem FindItem_Internal(int id);

        int GetRow_Internal(int id);

        TreeViewItem GetItem_Internal(int row);

        IList<TreeViewItem> GetRows_Internal();

        bool IsRevealed_Internal(int id);

        void RevealItem_Internal(int id);

        void RevealItems_Internal(int[] ids);

        void SetExpandedWithChildren_Internal(TreeViewItem item, bool expand);

        void SetExpanded_Internal(TreeViewItem item, bool expand);

        bool IsExpanded_Internal(TreeViewItem item);

        bool IsExpandable_Internal(TreeViewItem item);

        void SetExpandedWithChildren_Internal(int id, bool expand);

        int[] GetExpandedIDs_Internal();

        void SetExpandedIDs_Internal(int[] ids);

        bool SetExpanded_Internal(int id, bool expand);

        bool IsExpanded_Internal(int id);

        bool CanBeMultiSelected_Internal(TreeViewItem item);

        bool CanBeParent_Internal(TreeViewItem item);

        List<int> GetNewSelection_Internal(TreeViewItem clickedItem, TreeViewSelectState selectState);

        bool IsRenamingItemAllowed_Internal(TreeViewItem item);

        void InsertFakeItem_Internal(int id, int parentID, string name, Texture2D icon);

        void RemoveFakeItem_Internal();

        bool HasFakeItem_Internal();

        void OnSearchChanged_Internal();
    }
}