using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public abstract class TreeViewDataSource_Internal : ITreeViewDataSource_Internal
    {
        public abstract TreeViewItem root { get; }
        public abstract int rowCount { get; }

        public abstract void OnInitialize();
        public abstract void ReloadData();
        public abstract void InitIfNeeded();

        public abstract TreeViewItem FindItem(int id);

        public abstract int GetRow(int id);

        public abstract TreeViewItem GetItem(int row);

        public abstract IList<TreeViewItem> GetRows();

        public abstract bool IsRevealed(int id);

        public abstract void RevealItem(int id);

        public abstract void RevealItems(int[] ids);

        public abstract void SetExpandedWithChildren(TreeViewItem item, bool expand);

        public abstract void SetExpanded(TreeViewItem item, bool expand);

        public abstract bool IsExpanded(TreeViewItem item);

        public abstract bool IsExpandable(TreeViewItem item);

        public abstract void SetExpandedWithChildren(int id, bool expand);

        public abstract int[] GetExpandedIDs();

        public abstract void SetExpandedIDs(int[] ids);

        public abstract bool SetExpanded(int id, bool expand);

        public abstract bool IsExpanded(int id);

        public abstract bool CanBeMultiSelected(TreeViewItem item);

        public abstract bool CanBeParent(TreeViewItem item);

        public List<int> GetNewSelection(TreeViewItem clickedItem, TreeViewSelectState selectState)
        {
            return GetNewSelection_Internal(clickedItem, new TreeViewSelectState_Internals(selectState));
        }

        protected abstract List<int> GetNewSelection_Internal(TreeViewItem clickedItem, TreeViewSelectState_Internals selectState);

        public abstract bool IsRenamingItemAllowed(TreeViewItem item);

        public abstract void InsertFakeItem(int id, int parentID, string name, Texture2D icon);

        public abstract void RemoveFakeItem();

        public abstract bool HasFakeItem();

        public abstract void OnSearchChanged();
    }
}