﻿using System;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public class TreeViewDataSource_Internal : TreeViewDataSource, ITreeViewDataSource_Internal
    {
        public TreeViewItem root_Internal
        {
            get => root;
            set => this.m_RootItem = value;
        }

        public IList<TreeViewItem> rows_Internal
        {
            get => m_Rows;
            set => this.m_Rows = value;
        }

        public bool needRefreshRows_Internal
        {
            get => this.m_NeedRefreshRows;
            set => this.m_NeedRefreshRows = value;
        }

        public TreeViewItem fakeItem_Internal
        {
            get => m_FakeItem;
            set => m_FakeItem = value;
        }

        public Action onVisibleRowsChanged_Internal
        {
            get => onVisibleRowsChanged;
            set => onVisibleRowsChanged = value;
        }

        public bool showRootItem_Internal
        {
            get => showRootItem;
            set => showRootItem = value;
        }

        public bool rootIsCollapsable_Internal
        {
            get => rootIsCollapsable;
            set => rootIsCollapsable = value;
        }

        public bool alwaysAddFirstItemToSearchResult_Internal
        {
            get => alwaysAddFirstItemToSearchResult;
            set => alwaysAddFirstItemToSearchResult = value;
        }

        public List<int> expandedIDs_Internal
        {
            get => expandedIDs;
            set => expandedIDs = value;
        }

        public bool isInitialized_Internal => isInitialized;

        public int rowCount_Internal => rowCount;

        public override int rowCount => rowCountOverride_Internal;
        public virtual int rowCountOverride_Internal => base.rowCount;

        public TreeViewDataSource_Internal(TreeViewController_Internals treeView) : base(treeView) { }

        public override void OnInitialize()
        {
            OnInitializeOverride_Internal();
        }

        public virtual void OnInitializeOverride_Internal() { }

        public override void FetchData()
        {
            FetchData_Internal();
        }

        public virtual void FetchData_Internal() { }

        public override void ReloadData()
        {
            ReloadDataOverride_Internal();
        }

        public virtual void ReloadDataOverride_Internal()
        {
            base.ReloadData();
        }

        public override TreeViewItem FindItem(int id)
        {
            return FindItemOverride_Internal(id);
        }

        public virtual TreeViewItem FindItemOverride_Internal(int id)
        {
            return base.FindItem(id);
        }

        public override bool IsRevealed(int id)
        {
            return IsRevealedOverride_Internal(id);
        }

        public virtual bool IsRevealedOverride_Internal(int id)
        {
            return base.IsRevealed(id);
        }

        public override void RevealItem(int id)
        {
            RevealItemOverride_Internal(id);
        }

        public virtual void RevealItemOverride_Internal(int id)
        {
            base.RevealItem(id);
        }

        public override void RevealItems(int[] ids)
        {
            RevealItemsOverride_Internal(ids);
        }

        public virtual void RevealItemsOverride_Internal(int[] ids)
        {
            base.RevealItems(ids);
        }

        public override void OnSearchChanged()
        {
            OnSearchChangedOverride_Internal();
        }

        public virtual void OnSearchChangedOverride_Internal()
        {
            base.OnSearchChanged();
        }

        protected override List<TreeViewItem> ExpandedRows(TreeViewItem root)
        {
            return ExpandedRowsOverride_Internal(root);
        }

        public virtual List<TreeViewItem> ExpandedRowsOverride_Internal(TreeViewItem root)
        {
            return base.ExpandedRows(root);
        }

        protected override List<TreeViewItem> Search(TreeViewItem root, string search)
        {
            return SearchOverride_Internal(root, search);
        }

        public virtual List<TreeViewItem> SearchOverride_Internal(TreeViewItem root, string search)
        {
            return base.Search(root, search);
        }

        public override int GetRow(int id)
        {
            return GetRowOverride_Internal(id);
        }

        public virtual int GetRowOverride_Internal(int id)
        {
            return base.GetRow(id);
        }

        public override TreeViewItem GetItem(int row)
        {
            return GetItemOverride_Internal(row);
        }

        public virtual TreeViewItem GetItemOverride_Internal(int row)
        {
            return base.GetItem(row);
        }

        public override IList<TreeViewItem> GetRows()
        {
            return GetRowsOverride_Internal();
        }

        public virtual IList<TreeViewItem> GetRowsOverride_Internal()
        {
            return base.GetRows();
        }

        public override void InitIfNeeded()
        {
            InitIfNeededOverride_Internal();
        }

        public virtual void InitIfNeededOverride_Internal()
        {
            base.InitIfNeeded();
        }

        public override int[] GetExpandedIDs()
        {
            return GetExpandedIDsOverride_Internal();
        }

        public virtual int[] GetExpandedIDsOverride_Internal()
        {
            return base.GetExpandedIDs();
        }

        public override void SetExpandedIDs(int[] ids)
        {
            SetExpandedIDsOverride_Internal(ids);
        }

        public virtual void SetExpandedIDsOverride_Internal(int[] ids)
        {
            base.SetExpandedIDs(ids);
        }

        public override bool IsExpanded(int id)
        {
            return IsExpandedOverride_Internal(id);
        }

        public virtual bool IsExpandedOverride_Internal(int id)
        {
            return base.IsExpanded(id);
        }

        public override bool SetExpanded(int id, bool expand)
        {
            return SetExpandedOverride_Internal(id, expand);
        }

        public virtual bool SetExpandedOverride_Internal(int id, bool expand)
        {
            return base.SetExpanded(id, expand);
        }

        public override void SetExpandedWithChildren(int id, bool expand)
        {
            SetExpandedWithChildrenOverride_Internal(id, expand);
        }

        public virtual void SetExpandedWithChildrenOverride_Internal(int id, bool expand)
        {
            base.SetExpandedWithChildren(id, expand);
        }

        public override void SetExpandedWithChildren(TreeViewItem fromItem, bool expand)
        {
            SetExpandedWithChildrenOverride_Internal(fromItem, expand);
        }

        public virtual void SetExpandedWithChildrenOverride_Internal(TreeViewItem fromItem, bool expand)
        {
            base.SetExpandedWithChildren(fromItem, expand);
        }

        public override void SetExpanded(TreeViewItem item, bool expand)
        {
            SetExpandedOverride_Internal(item, expand);
        }

        public virtual void SetExpandedOverride_Internal(TreeViewItem item, bool expand)
        {
            base.SetExpanded(item, expand);
        }

        public override bool IsExpanded(TreeViewItem item)
        {
            return IsExpandedOverride_Internal(item);
        }

        public virtual bool IsExpandedOverride_Internal(TreeViewItem item)
        {
            return base.IsExpanded(item);
        }

        public override bool IsExpandable(TreeViewItem item)
        {
            return IsExpandableOverride_Internal(item);
        }

        public virtual bool IsExpandableOverride_Internal(TreeViewItem item)
        {
            return base.IsExpandable(item);
        }

        public override bool CanBeMultiSelected(TreeViewItem item)
        {
            return CanBeMultiSelectedOverride_Internal(item);
        }

        public virtual bool CanBeMultiSelectedOverride_Internal(TreeViewItem item)
        {
            return base.CanBeMultiSelected(item);
        }

        public override bool CanBeParent(TreeViewItem item)
        {
            return CanBeParentOverride_Internal(item);
        }

        public virtual bool CanBeParentOverride_Internal(TreeViewItem item)
        {
            return base.CanBeParent(item);
        }

        public override List<int> GetNewSelection(TreeViewItem clickedItem, TreeViewSelectState selectState)
        {
            return GetNewSelection_Internal(clickedItem, new TreeViewSelectState_Internals(selectState));
        }

        public virtual List<int> GetNewSelection_Internal(TreeViewItem clickedItem, TreeViewSelectState_Internals selectState)
        {
            return base.GetNewSelection(clickedItem, selectState.value);
        }

        public override void OnExpandedStateChanged()
        {
            OnExpandedStateChanged_Internal();
        }

        public virtual void OnExpandedStateChanged_Internal()
        {
            base.OnExpandedStateChanged();
        }

        public override bool IsRenamingItemAllowed(TreeViewItem item)
        {
            return IsRenamingItemAllowedOverride_Internal(item);
        }

        public virtual bool IsRenamingItemAllowedOverride_Internal(TreeViewItem item)
        {
            return base.IsRenamingItemAllowed(item);
        }

        public override void InsertFakeItem(int id, int parentID, string name, Texture2D icon)
        {
            InsertFakeItemOverride_Internal(id, parentID, name, icon);
        }

        public virtual void InsertFakeItemOverride_Internal(int id, int parentID, string name, Texture2D icon)
        {
            base.InsertFakeItem(id, parentID, name, icon);
        }

        public override bool HasFakeItem()
        {
            return HasFakeItemOverride_Internal();
        }

        public virtual bool HasFakeItemOverride_Internal()
        {
            return base.HasFakeItem();
        }

        public override void RemoveFakeItem()
        {
            RemoveFakeItemOverride_Internal();
        }

        public virtual void RemoveFakeItemOverride_Internal()
        {
            base.RemoveFakeItem();
        }

        public void OnInitialize_Internal()
        {
            OnInitialize();
        }

        public void ReloadData_Internal()
        {
            ReloadData();
        }

        public void InitIfNeeded_Internal()
        {
            InitIfNeeded();
        }

        public TreeViewItem FindItem_Internal(int id)
        {
            return FindItem(id);
        }

        public int GetRow_Internal(int id)
        {
            return GetRow(id);
        }

        public TreeViewItem GetItem_Internal(int row)
        {
            return GetItem(row);
        }

        public IList<TreeViewItem> GetRows_Internal()
        {
            return GetRows();
        }

        public bool IsRevealed_Internal(int id)
        {
            return IsRevealed(id);
        }

        public void RevealItem_Internal(int id)
        {
            RevealItem(id);
        }

        public void RevealItems_Internal(int[] ids)
        {
            RevealItems(ids);
        }

        public void SetExpandedWithChildren_Internal(TreeViewItem item, bool expand)
        {
            SetExpandedWithChildren(item, expand);
        }

        public void SetExpanded_Internal(TreeViewItem item, bool expand)
        {
            SetExpanded(item, expand);
        }

        public bool IsExpanded_Internal(TreeViewItem item)
        {
            return IsExpanded(item);
        }

        public bool IsExpandable_Internal(TreeViewItem item)
        {
            return IsExpandable(item);
        }

        public void SetExpandedWithChildren_Internal(int id, bool expand)
        {
            SetExpandedWithChildren(id, expand);
        }

        public int[] GetExpandedIDs_Internal()
        {
            return GetExpandedIDs();
        }

        public void SetExpandedIDs_Internal(int[] ids)
        {
            SetExpandedIDs(ids);
        }

        public bool SetExpanded_Internal(int id, bool expand)
        {
            return SetExpanded(id, expand);
        }

        public bool IsExpanded_Internal(int id)
        {
            return IsExpanded(id);
        }

        public bool CanBeMultiSelected_Internal(TreeViewItem item)
        {
            return CanBeMultiSelected(item);
        }

        public bool CanBeParent_Internal(TreeViewItem item)
        {
            return CanBeParent(item);
        }

        public List<int> GetNewSelection_Internal(TreeViewItem clickedItem, TreeViewSelectState selectState)
        {
            return GetNewSelection(clickedItem, selectState);
        }

        public bool IsRenamingItemAllowed_Internal(TreeViewItem item)
        {
            return IsRenamingItemAllowed(item);
        }

        public void InsertFakeItem_Internal(int id, int parentID, string name, Texture2D icon)
        {
            InsertFakeItem(id, parentID, name, icon);
        }

        public void RemoveFakeItem_Internal()
        {
            RemoveFakeItem();
        }

        public bool HasFakeItem_Internal()
        {
            return HasFakeItem();
        }

        public void OnSearchChanged_Internal()
        {
            OnSearchChanged();
        }

        public void GetVisibleItemsRecursive_Internal(TreeViewItem item, List<TreeViewItem> visibleItems)
        {
            GetVisibleItemsRecursive(item, visibleItems);
        }

        public void SearchRecursive_Internal(TreeViewItem item, string search, List<TreeViewItem> searchResult)
        {
            SearchRecursive(item, search, searchResult);
        }
    }
}