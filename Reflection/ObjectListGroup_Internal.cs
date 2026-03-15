using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public struct ObjectListItemFader_Internal
    {
        private ObjectListArea.LocalGroup.ItemFader _itemFader;

        internal ObjectListArea.LocalGroup.ItemFader Target_Internal => _itemFader;

        public bool isValid_Internal => _itemFader != null;

        public ObjectListItemFader_Internal(ObjectListArea.LocalGroup.ItemFader itemFader)
        {
            _itemFader = itemFader;
        }

        public void Start_Internal(List<int> instanceIDs)
        {
            _itemFader.Start(instanceIDs);
        }

        public float GetAlpha_Internal(int instanceID) => _itemFader.GetAlpha(instanceID);
    }

    public struct ObjectListGroup_Internal
    {
        private ObjectListArea.Group _group;

        internal ObjectListArea.Group Target_Internal => _group;

        public bool isValid_Internal => _group != null;

        public ObjectListGroup_Internal(ObjectListArea.Group group)
        {
            _group = group;
        }

        public static int[] s_Empty_Internal
        {
            get => ObjectListArea.Group.s_Empty;
            set => ObjectListArea.Group.s_Empty = value;
        }

        public float kGroupSeparatorHeight_Internal
        {
            get => _group.kGroupSeparatorHeight;
        }

        public string m_GroupSeparatorTitle_Internal
        {
            get => _group.m_GroupSeparatorTitle;
            set => _group.m_GroupSeparatorTitle = value;
        }

        public ObjectListArea_Internal m_Owner_Internal
        {
            get => _group.m_Owner as ObjectListArea_Internal;
            set => _group.m_Owner = value;
        }

        public VerticalGrid m_Grid_Internal
        {
            get => _group.m_Grid;
            set => _group.m_Grid = value;
        }

        public float m_Height_Internal
        {
            get => _group.m_Height;
            set => _group.m_Height = value;
        }

        public bool Visible_Internal
        {
            get => _group.Visible;
            set => _group.Visible = value;
        }

        public int ItemsAvailable_Internal
        {
            get => _group.ItemsAvailable;
            set => _group.ItemsAvailable = value;
        }

        public int ItemsWantedShown_Internal
        {
            get => _group.ItemsWantedShown;
            set => _group.ItemsWantedShown = value;
        }

        public bool m_Collapsable_Internal
        {
            get => _group.m_Collapsable;
            set => _group.m_Collapsable = value;
        }

        public double m_LastClickedDrawTime_Internal
        {
            get => _group.m_LastClickedDrawTime;
            set => _group.m_LastClickedDrawTime = value;
        }

        public float Height_Internal => _group.Height;

        public int ItemCount_Internal => _group.ItemCount;

        public bool ListMode_Internal
        {
            get => _group.ListMode;
            set => _group.ListMode = value;
        }

        public bool NeedsRepaint_Internal => _group.NeedsRepaint;

        public bool visiblePreference_Internal
        {
            get => _group.visiblePreference;
            set => _group.visiblePreference = value;
        }

        public void Draw_Internal(float yOffset, Vector2 scrollPos, ref int rowsInUse)
        {
            _group.Draw(yOffset, scrollPos, ref rowsInUse);
        }

        public void UpdateAssets_Internal()
        {
            _group.UpdateAssets();
        }

        public void UpdateHeight_Internal()
        {
            _group.UpdateHeight();
        }

        public void UpdateFilter_Internal(HierarchyType hierarchyType, SearchFilter searchFilter, bool showFoldersFirst)
        {
            _group.UpdateFilter(hierarchyType, searchFilter, showFoldersFirst);
        }

        public void UpdateFilter_Internal(
            HierarchyType hierarchyType,
            SearchFilter searchFilter,
            bool showFoldersFirst,
            SearchSessionOptions_Internal searchSessionOptions)
        {
            _group.UpdateFilter(hierarchyType, searchFilter, showFoldersFirst, searchSessionOptions.Target_Internal);
        }

        public float GetHeaderHeight_Internal() => _group.GetHeaderHeight();

        public void HandleUnusedDragEvents_Internal(float yOffset)
        {
            _group.HandleUnusedDragEvents(yOffset);
        }

        public int FirstVisibleRow_Internal(float yOffset, Vector2 scrollPos) => _group.FirstVisibleRow(yOffset, scrollPos);

        public bool IsInView_Internal(float yOffset, Vector2 scrollPos, float scrollViewHeight) =>
            _group.IsInView(yOffset, scrollPos, scrollViewHeight);

        public void DrawObjectIcon_Internal(Rect position, Texture icon)
        {
            _group.DrawObjectIcon(position, icon);
        }

        public void DrawDropShadowOverlay_Internal(Rect position, bool selected, bool isDropTarget, bool isRenaming)
        {
            _group.DrawDropShadowOverlay(position, selected, isDropTarget, isRenaming);
        }

        public void DrawHeaderBackground_Internal(Rect rect, bool firstHeader, bool expanded)
        {
            _group.DrawHeaderBackground(rect, firstHeader, expanded);
        }

        public float GetHeaderYPosInScrollArea_Internal(float yOffset) => _group.GetHeaderYPosInScrollArea(yOffset);

        public void DrawHeader_Internal(float yOffset, bool collapsable)
        {
            _group.DrawHeader(yOffset, collapsable);
        }

        public void DrawItemCount_Internal(Rect rect)
        {
            _group.DrawItemCount(rect);
        }
    }

    public struct ObjectListLocalGroup_Internal
    {
        private ObjectListArea.LocalGroup _localGroup;

        internal ObjectListArea.LocalGroup Target_Internal => _localGroup;

        public bool isValid_Internal => _localGroup != null;

        public ObjectListLocalGroup_Internal(ObjectListArea.LocalGroup localGroup)
        {
            _localGroup = localGroup;
        }

        public ObjectListGroup_Internal group_Internal => new ObjectListGroup_Internal(_localGroup);

        public static int k_ListModeLeftPadding_Internal => ObjectListArea.LocalGroup.k_ListModeLeftPadding;

        public static int k_ListModeLeftPaddingForSubAssets_Internal => ObjectListArea.LocalGroup.k_ListModeLeftPaddingForSubAssets;

        public static int k_ListModeVersionControlOverlayPadding_Internal => ObjectListArea.LocalGroup.k_ListModeVersionControlOverlayPadding;

        public static int k_ListModeExternalIconPadding_Internal => ObjectListArea.LocalGroup.k_ListModeExternalIconPadding;

        public static float k_IconWidth_Internal => ObjectListArea.LocalGroup.k_IconWidth;

        public static float k_SpaceBetweenIconAndText_Internal => ObjectListArea.LocalGroup.k_SpaceBetweenIconAndText;

        public BuiltinResource[] m_NoneList_Internal
        {
            get => _localGroup.m_NoneList;
            set => _localGroup.m_NoneList = value;
        }

        public GUIContent m_Content_Internal
        {
            get => _localGroup.m_Content;
            set => _localGroup.m_Content = value;
        }

        public List<int> m_DragSelection_Internal
        {
            get => _localGroup.m_DragSelection;
            set => _localGroup.m_DragSelection = value;
        }

        public int m_DropTargetControlID_Internal
        {
            get => _localGroup.m_DropTargetControlID;
            set => _localGroup.m_DropTargetControlID = value;
        }

        public List<Type> m_AssetPreviewIgnoreList_Internal
        {
            get => _localGroup.m_AssetPreviewIgnoreList;
            set => _localGroup.m_AssetPreviewIgnoreList = value;
        }

        public List<string> m_AssetExtensionsPreviewIgnoreList_Internal
        {
            get => _localGroup.m_AssetExtensionsPreviewIgnoreList;
            set => _localGroup.m_AssetExtensionsPreviewIgnoreList = value;
        }

        public Dictionary<string, BuiltinResource[]> m_BuiltinResourceMap_Internal
        {
            get => _localGroup.m_BuiltinResourceMap;
            set => _localGroup.m_BuiltinResourceMap = value;
        }

        public BuiltinResource[] m_CurrentBuiltinResources_Internal
        {
            get => _localGroup.m_CurrentBuiltinResources;
            set => _localGroup.m_CurrentBuiltinResources = value;
        }

        public bool m_ShowNoneItem_Internal
        {
            get => _localGroup.m_ShowNoneItem;
            set => _localGroup.m_ShowNoneItem = value;
        }

        public List<int> m_LastRenderedAssetInstanceIDs_Internal
        {
            get => _localGroup.m_LastRenderedAssetInstanceIDs;
            set => _localGroup.m_LastRenderedAssetInstanceIDs = value;
        }

        public List<int> m_LastRenderedAssetDirtyCounts_Internal
        {
            get => _localGroup.m_LastRenderedAssetDirtyCounts;
            set => _localGroup.m_LastRenderedAssetDirtyCounts = value;
        }

        public bool m_ListMode_Internal
        {
            get => _localGroup.m_ListMode;
            set => _localGroup.m_ListMode = value;
        }

        public FilteredHierarchy_Internal m_FilteredHierarchy_Internal
        {
            get => new FilteredHierarchy_Internal(_localGroup.m_FilteredHierarchy);
            set => _localGroup.m_FilteredHierarchy = value.Target_Internal;
        }

        public BuiltinResource[] m_ActiveBuiltinList_Internal
        {
            get => _localGroup.m_ActiveBuiltinList;
            set => _localGroup.m_ActiveBuiltinList = value;
        }

        public ObjectListItemFader_Internal m_ItemFader_Internal
        {
            get => new ObjectListItemFader_Internal(_localGroup.m_ItemFader);
            set => _localGroup.m_ItemFader = value.Target_Internal;
        }

        public Action m_OwnerRepaintAction_Internal
        {
            get => _localGroup.m_OwnerRepaintAction;
        }

        public bool ShowNone_Internal => _localGroup.ShowNone;

        public bool NeedsRepaint_Internal => _localGroup.NeedsRepaint;

        public SearchFilter searchFilter_Internal => _localGroup.searchFilter;

        public bool ListMode_Internal
        {
            get => _localGroup.ListMode;
            set => _localGroup.ListMode = value;
        }

        public bool HasBuiltinResources_Internal => _localGroup.HasBuiltinResources;

        public int projectItemCount_Internal => _localGroup.projectItemCount;

        public int ItemCount_Internal => _localGroup.ItemCount;

        public void AddTypetoAssetPreviewIgnoreList_Internal(Type assetType)
        {
            _localGroup.AddTypetoAssetPreviewIgnoreList(assetType);
        }

        public void UpdateAssets_Internal()
        {
            _localGroup.UpdateAssets();
        }

        public float GetHeaderHeight_Internal() => _localGroup.GetHeaderHeight();

        public void DrawHeader_Internal(float yOffset, bool collapsable)
        {
            _localGroup.DrawHeader(yOffset, collapsable);
        }

        public void UpdateHeight_Internal()
        {
            _localGroup.UpdateHeight();
        }

        public bool IsCreatingAtThisIndex_Internal(int itemIdx) => _localGroup.IsCreatingAtThisIndex(itemIdx);

        public void DrawInternal_Internal(int beginIndex, int endIndex, float yOffset)
        {
            _localGroup.DrawInternal(beginIndex, endIndex, yOffset);
        }

        public void ClearDirtyStateTracking_Internal()
        {
            _localGroup.ClearDirtyStateTracking();
        }

        public void AddDirtyStateFor_Internal(int instanceID)
        {
            _localGroup.AddDirtyStateFor(instanceID);
        }

        public bool IsAnyLastRenderedAssetsDirty_Internal() => _localGroup.IsAnyLastRenderedAssetsDirty();

        public void HandleUnusedDragEvents_Internal(float yOffset)
        {
            _localGroup.HandleUnusedDragEvents(yOffset);
        }

        public void HandleMouseWithDragging_Internal(ref AssetReference_Internal assetReference, int controlID, Rect rect)
        {
            var target = assetReference.Target_Internal;
            _localGroup.HandleMouseWithDragging(ref target, controlID, rect);
            assetReference = new AssetReference_Internal(target);
        }

        public void HandleMouseWithoutDragging_Internal(ref AssetReference_Internal assetReference, int controlID, Rect position)
        {
            var target = assetReference.Target_Internal;
            _localGroup.HandleMouseWithoutDragging(ref target, controlID, position);
            assetReference = new AssetReference_Internal(target);
        }

        public void HandleContextClick_Internal(Event evt, Rect rect)
        {
            ObjectListArea.LocalGroup.HandleContextClick(evt, rect);
        }

        public bool IsExpanded_Internal(int instanceID) => _localGroup.IsExpanded(instanceID);

        public void ChangeExpandedState_Internal(int instanceID, bool expanded)
        {
            _localGroup.ChangeExpandedState(instanceID, expanded);
        }

        public bool IsBuiltinAsset_Internal(int instanceID) => _localGroup.IsBuiltinAsset(instanceID);

        public bool IsRenaming_Internal(int instanceID) => _localGroup.IsRenaming(instanceID);

        public void GetAssetReferences_Internal(out List<int> instanceIDs, out List<string> guids)
        {
            _localGroup.GetAssetReferences(out instanceIDs, out guids);
        }

        public string GetNameOfLocalAsset_Internal(int instanceID) => _localGroup.GetNameOfLocalAsset(instanceID);

        public List<int> GetNewSelection_Internal(ref AssetReference_Internal clickedAssetReference, bool beginOfDrag, bool useShiftAsActionKey)
        {
            var target = clickedAssetReference.Target_Internal;
            List<int> result = _localGroup.GetNewSelection(ref target, beginOfDrag, useShiftAsActionKey);
            clickedAssetReference = new AssetReference_Internal(target);
            return result;
        }

        public Rect ActualImageDrawPosition_Internal(Rect position, float imageWidth, float imageHeight) =>
            ObjectListArea.LocalGroup.ActualImageDrawPosition(position, imageWidth, imageHeight);

        public void DrawSubAssetRowBg_Internal(int startSubAssetIndex, int endSubAssetIndex, bool continued, float yOffset)
        {
            _localGroup.DrawSubAssetRowBg(startSubAssetIndex, endSubAssetIndex, continued, yOffset);
        }

        public void DrawSubAssetBackground_Internal(int beginIndex, int endIndex, float yOffset)
        {
            _localGroup.DrawSubAssetBackground(beginIndex, endIndex, yOffset);
        }

        public void DrawItem_Internal(Rect position, FilteredHierarchyFilterResult_Internal filterItem, BuiltinResource builtinResource, bool isFolderBrowsing)
        {
            _localGroup.DrawItem(position, filterItem.Target_Internal, builtinResource, isFolderBrowsing);
        }

        public void BeginPing_Internal(int instanceID)
        {
            _localGroup.BeginPing(instanceID);
        }

        public void SelectAndFrameParentOf_Internal(int instanceID)
        {
            _localGroup.SelectAndFrameParentOf(instanceID);
        }

        public void RefreshHierarchy_Internal(
            HierarchyType hierarchyType,
            SearchFilter searchFilter,
            bool foldersFirst,
            SearchSessionOptions_Internal searchSessionOptions)
        {
            _localGroup.RefreshHierarchy(hierarchyType, searchFilter, foldersFirst, searchSessionOptions.Target_Internal);
        }

        public void RefreshBuiltinResourceList_Internal(SearchFilter searchFilter)
        {
            _localGroup.RefreshBuiltinResourceList(searchFilter);
        }

        public void UpdateFilter_Internal(
            HierarchyType hierarchyType,
            SearchFilter searchFilter,
            bool foldersFirst,
            SearchSessionOptions_Internal searchSessionOptions)
        {
            _localGroup.UpdateFilter(hierarchyType, searchFilter, foldersFirst, searchSessionOptions.Target_Internal);
        }

        public bool ShouldGetAssetPreview_Internal(int instanceID) => _localGroup.ShouldGetAssetPreview(instanceID);

        public void InitBuiltinResources_Internal()
        {
            _localGroup.InitBuiltinResources();
        }

        public void PrintBuiltinResourcesAvailable_Internal()
        {
            _localGroup.PrintBuiltinResourcesAvailable();
        }

        public int IndexOfNewText_Internal(string newText, bool isCreatingNewFolder, bool foldersFirst) =>
            _localGroup.IndexOfNewText(newText, isCreatingNewFolder, foldersFirst);

        public int IndexOf_Internal(int instanceID) => _localGroup.IndexOf(instanceID);

        public FilteredHierarchyFilterResult_Internal LookupByInstanceID_Internal(int instanceID) =>
            new FilteredHierarchyFilterResult_Internal(_localGroup.LookupByInstanceID(instanceID));

        public bool AssetReferenceAtIndex_Internal(int index, out AssetReference_Internal assetReference)
        {
            bool result = _localGroup.AssetReferenceAtIndex(index, out var target);
            assetReference = new AssetReference_Internal(target);
            return result;
        }

        public void StartDrag_Internal(int draggedInstanceID, List<int> selectedInstanceIDs)
        {
            _localGroup.StartDrag(draggedInstanceID, selectedInstanceIDs);
        }

        public DragAndDropVisualMode DoDrag_Internal(int dragToInstanceID, bool perform) => _localGroup.DoDrag(dragToInstanceID, perform);

        public static int GetControlIDFromInstanceID_Internal(int instanceID) => ObjectListArea.LocalGroup.GetControlIDFromInstanceID(instanceID);

        public bool DoCharacterOffsetSelection_Internal() => _localGroup.DoCharacterOffsetSelection();

        public void ShowObjectsInList_Internal(int[] instanceIDs)
        {
            _localGroup.ShowObjectsInList(instanceIDs);
        }

        public void ShowObjectsInList_Internal(int[] instanceIDs, string[] rootPaths)
        {
            _localGroup.ShowObjectsInList(instanceIDs, rootPaths);
        }

        public void DrawIconAndLabel_Internal(
            Rect rect,
            FilteredHierarchyFilterResult_Internal filterItem,
            string label,
            Texture2D icon,
            bool selected,
            bool focus)
        {
            _localGroup.DrawIconAndLabel(rect, filterItem.Target_Internal, label, icon, selected, focus);
        }

        public static bool DrawExternalPostLabelInList_Internal(Rect drawRect, FilteredHierarchyFilterResult_Internal filterItem) =>
            ObjectListArea.LocalGroup.DrawExternalPostLabelInList(drawRect, filterItem.Target_Internal);
    }
}
