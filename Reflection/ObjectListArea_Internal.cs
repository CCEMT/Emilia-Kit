using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.SearchService;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public class ObjectListArea_Internal : ObjectListArea
    {
        public delegate void OnAssetIconDrawDelegate_Internal(Rect iconRect, string guid, bool isListMode);

        public delegate bool OnAssetLabelDrawDelegate_Internal(Rect drawRect, string guid, bool isListMode);

        public static float k_ListModeVersionControlOverlayPadding_Internal => k_ListModeVersionControlOverlayPadding;

        public static int kHome_Internal => kHome;

        public static int kEnd_Internal => kEnd;

        public static int kPageDown_Internal => kPageDown;

        public static int kPageUp_Internal => kPageUp;

        public static int kListLineHeight_Internal => kListLineHeight;

        public static int kSpaceForScrollBar_Internal => kSpaceForScrollBar;

        public static bool s_Debug_Internal
        {
            get => s_Debug;
            set => s_Debug = value;
        }

        public static bool s_VCEnabled_Internal
        {
            get => s_VCEnabled;
            set => s_VCEnabled = value;
        }

        public ObjectListArea_Internal(ObjectListAreaState_Internal state, EditorWindow owner, bool showNoneItem)
            : base(state, owner, showNoneItem)
        {
        }

        public double LastScrollTime_Internal
        {
            get => LastScrollTime;
            set => LastScrollTime = value;
        }

        public float m_SpaceBetween_Internal
        {
            get => m_SpaceBetween;
            set => m_SpaceBetween = value;
        }

        public float m_TopMargin_Internal
        {
            get => m_TopMargin;
            set => m_TopMargin = value;
        }

        public float m_BottomMargin_Internal
        {
            get => m_BottomMargin;
            set => m_BottomMargin = value;
        }

        public float m_RightMargin_Internal
        {
            get => m_RightMargin;
            set => m_RightMargin = value;
        }

        public float m_LeftMargin_Internal
        {
            get => m_LeftMargin;
            set => m_LeftMargin = value;
        }

        public bool m_AllowRenameOnMouseUp_Internal
        {
            get => m_AllowRenameOnMouseUp;
            set => m_AllowRenameOnMouseUp = value;
        }

        public bool m_AllowThumbnails_Internal
        {
            get => m_AllowThumbnails;
            set => m_AllowThumbnails = value;
        }

        public AssetReferenceStringDictionary_Internal m_AssetReferenceToCroppedNameMap_Internal
        {
            get => new AssetReferenceStringDictionary_Internal(m_AssetReferenceToCroppedNameMap);
            set => m_AssetReferenceToCroppedNameMap = value.Target_Internal;
        }

        public bool m_FrameLastClickedItem_Internal
        {
            get => m_FrameLastClickedItem;
            set => m_FrameLastClickedItem = value;
        }

        public int m_KeyboardControlID_Internal
        {
            get => m_KeyboardControlID;
            set => m_KeyboardControlID = value;
        }

        public Vector2 m_LastScrollPosition_Internal
        {
            get => m_LastScrollPosition;
            set => m_LastScrollPosition = value;
        }

        public int m_LeftPaddingForPinging_Internal
        {
            get => m_LeftPaddingForPinging;
            set => m_LeftPaddingForPinging = value;
        }

        public ObjectListLocalGroup_Internal m_LocalAssets_Internal
        {
            get => new ObjectListLocalGroup_Internal(m_LocalAssets);
            set => m_LocalAssets = value.Target_Internal;
        }

        public List<ObjectListGroup_Internal> m_Groups_Internal
        {
            get
            {
                if (m_Groups == null)
                    return null;

                List<ObjectListGroup_Internal> groups = new List<ObjectListGroup_Internal>(m_Groups.Count);
                foreach (ObjectListArea.Group group in m_Groups)
                    groups.Add(new ObjectListGroup_Internal(group));
                return groups;
            }
            set
            {
                if (value == null)
                {
                    m_Groups = null;
                    return;
                }

                List<ObjectListArea.Group> groups = new List<ObjectListArea.Group>(value.Count);
                foreach (ObjectListGroup_Internal group in value)
                    groups.Add(group.Target_Internal);
                m_Groups = groups;
            }
        }

        public int m_MaxGridSize_Internal
        {
            get => m_MaxGridSize;
            set => m_MaxGridSize = value;
        }

        public int m_MinGridSize_Internal
        {
            get => m_MinGridSize;
            set => m_MinGridSize = value;
        }

        public int m_MinIconSize_Internal
        {
            get => m_MinIconSize;
            set => m_MinIconSize = value;
        }

        public double m_NextDirtyCheck_Internal
        {
            get => m_NextDirtyCheck;
            set => m_NextDirtyCheck = value;
        }

        public EditorWindow m_Owner_Internal
        {
            get => m_Owner;
            set => m_Owner = value;
        }

        public PingData_Internal m_Ping_Internal
        {
            get => new PingData_Internal(m_Ping);
            set => m_Ping = value.Target_Internal;
        }

        public int m_pingIndex_Internal
        {
            get => m_pingIndex;
            set => m_pingIndex = value;
        }

        public ProjectSearchSessionHandler_Internal m_SearchSessionHandler_Internal => new ProjectSearchSessionHandler_Internal(m_SearchSessionHandler);

        public Texture m_SelectedObjectIcon_Internal
        {
            get => m_SelectedObjectIcon;
            set => m_SelectedObjectIcon = value;
        }

        public int m_SelectionOffset_Internal
        {
            get => m_SelectionOffset;
            set => m_SelectionOffset = value;
        }

        public bool m_ShowLocalAssetsOnly_Internal
        {
            get => m_ShowLocalAssetsOnly;
            set => m_ShowLocalAssetsOnly = value;
        }

        public ObjectListAreaState_Internal m_State_Internal
        {
            get => m_State as ObjectListAreaState_Internal;
            set => m_State = value;
        }

        public Rect m_TotalRect_Internal
        {
            get => m_TotalRect;
            set => m_TotalRect = value;
        }

        public Rect m_VisibleRect_Internal
        {
            get => m_VisibleRect;
            set => m_VisibleRect = value;
        }

        public int m_WidthUsedForCroppingName_Internal
        {
            get => m_WidthUsedForCroppingName;
            set => m_WidthUsedForCroppingName = value;
        }

        public bool allowDragging_Internal
        {
            get => allowDragging;
            set => allowDragging = value;
        }

        public bool allowRenaming_Internal
        {
            get => allowRenaming;
            set => allowRenaming = value;
        }

        public bool allowMultiSelect_Internal
        {
            get => allowMultiSelect;
            set => allowMultiSelect = value;
        }

        public bool allowDeselection_Internal
        {
            get => allowDeselection;
            set => allowDeselection = value;
        }

        public bool allowFocusRendering_Internal
        {
            get => allowFocusRendering;
            set => allowFocusRendering = value;
        }

        public bool allowBuiltinResources_Internal
        {
            get => allowBuiltinResources;
            set => allowBuiltinResources = value;
        }

        public bool allowUserRenderingHook_Internal
        {
            get => allowUserRenderingHook;
            set => allowUserRenderingHook = value;
        }

        public bool allowFindNextShortcut_Internal
        {
            get => allowFindNextShortcut;
            set => allowFindNextShortcut = value;
        }

        public bool foldersFirst_Internal
        {
            get => foldersFirst;
            set => foldersFirst = value;
        }

        public Action repaintCallback_Internal
        {
            get => m_RepaintWantedCallback;
            set => m_RepaintWantedCallback = value;
        }

        public Action m_RepaintWantedCallback_Internal
        {
            get => m_RepaintWantedCallback;
            set => m_RepaintWantedCallback = value;
        }

        public Action<bool> itemSelectedCallback_Internal
        {
            get => m_ItemSelectedCallback;
            set => m_ItemSelectedCallback = value;
        }

        public Action<bool> m_ItemSelectedCallback_Internal
        {
            get => m_ItemSelectedCallback;
            set => m_ItemSelectedCallback = value;
        }

        public Action keyboardCallback_Internal
        {
            get => m_KeyboardInputCallback;
            set => m_KeyboardInputCallback = value;
        }

        public Action m_KeyboardInputCallback_Internal
        {
            get => m_KeyboardInputCallback;
            set => m_KeyboardInputCallback = value;
        }

        public Action gotKeyboardFocus_Internal
        {
            get => m_GotKeyboardFocus;
            set => m_GotKeyboardFocus = value;
        }

        public Action m_GotKeyboardFocus_Internal
        {
            get => m_GotKeyboardFocus;
            set => m_GotKeyboardFocus = value;
        }

        public Func<Rect, float> drawLocalAssetHeader_Internal
        {
            get => m_DrawLocalAssetHeader;
            set => m_DrawLocalAssetHeader = value;
        }

        public Func<Rect, float> m_DrawLocalAssetHeader_Internal
        {
            get => m_DrawLocalAssetHeader;
            set => m_DrawLocalAssetHeader = value;
        }

        public void ShowObjectsInList_Internal(int[] instanceIDs)
        {
            ShowObjectsInList(instanceIDs);
        }

        public void ShowObjectsInList_Internal(int[] instanceIDs, string[] rootPaths)
        {
            ShowObjectsInList(instanceIDs, rootPaths);
        }

        public string[] GetCurrentVisibleNames_Internal() => GetCurrentVisibleNames();

        public void Init_Internal(
            Rect rect,
            HierarchyType hierarchyType,
            SearchFilter_Internal searchFilter,
            bool checkThumbnails)
        {
            Init(rect, hierarchyType, searchFilter, checkThumbnails);
        }

        public void Init_Internal(
            Rect rect,
            HierarchyType hierarchyType,
            SearchFilter_Internal searchFilter,
            bool checkThumbnails,
            SearchSessionOptions_Internal searchSessionOptions)
        {
            Init(rect, hierarchyType, searchFilter, checkThumbnails, searchSessionOptions.Target_Internal);
        }

        public void InitForSearch_Internal(
            Rect rect,
            HierarchyType hierarchyType,
            SearchFilter_Internal searchFilter,
            bool checkThumbnails,
            Func<string, int> assetToInstanceId)
        {
            InitForSearch(rect, hierarchyType, searchFilter, checkThumbnails, assetToInstanceId);
        }

        public void InitForSearch_Internal(
            Rect rect,
            HierarchyType hierarchyType,
            SearchFilter_Internal searchFilter,
            bool checkThumbnails,
            Func<string, int> assetToInstanceId,
            SearchSessionOptions_Internal searchSessionOptions)
        {
            InitForSearch(rect, hierarchyType, searchFilter, checkThumbnails, assetToInstanceId, searchSessionOptions.Target_Internal);
        }

        public void InitListAreaWithItems_Internal(
            Rect rect,
            HierarchyType hierarchyType,
            SearchFilter_Internal searchFilter,
            bool checkThumbnails,
            IEnumerable<string> items,
            Func<string, int> assetToInstanceId,
            SearchSessionOptions_Internal searchSessionOptions)
        {
            InitListAreaWithItems(rect, hierarchyType, searchFilter, checkThumbnails, items, assetToInstanceId, searchSessionOptions.Target_Internal);
        }

        public bool HasFocus_Internal() => HasFocus();

        public float GetVisibleWidth_Internal() => GetVisibleWidth();

        public void OnGUI_Internal(Rect position, int keyboardControlID)
        {
            OnGUI(position, keyboardControlID);
        }

        public void FrameLastClickedItemIfWanted_Internal()
        {
            FrameLastClickedItemIfWanted();
        }

        public void HandleUnusedEvents_Internal()
        {
            HandleUnusedEvents();
        }

        public bool CanShowThumbnails_Internal() => CanShowThumbnails();

        public bool ObjectsHaveThumbnails_Internal(
            HierarchyType hierarchyType,
            SearchFilter_Internal searchFilter,
            SearchSessionOptions_Internal searchSessionOptions)
        {
            return ObjectsHaveThumbnails(hierarchyType, searchFilter, searchSessionOptions.Target_Internal);
        }

        public int gridSize_Internal
        {
            get => gridSize;
            set => gridSize = value;
        }

        public int minGridSize_Internal => m_MinGridSize;

        public int maxGridSize_Internal => m_MaxGridSize;

        public int numItemsDisplayed_Internal => m_LocalAssets.ItemCount;

        public void OnDestroy_Internal()
        {
            OnDestroy();
        }

        public void Repaint_Internal()
        {
            Repaint();
        }

        public void OnEvent_Internal()
        {
            OnEvent();
        }

        public CreateAssetUtility_Internal GetCreateAssetUtility_Internal() => new CreateAssetUtility_Internal(GetCreateAssetUtility());

        public RenameOverlay_Internals GetRenameOverlay_Internal() => new RenameOverlay_Internals(GetRenameOverlay());

        public void BeginNamingNewAsset_Internal(string newAssetName, int instanceID, bool isCreatingNewFolder)
        {
            BeginNamingNewAsset(newAssetName, instanceID, isCreatingNewFolder);
        }

        public bool BeginRename_Internal(float delay) => BeginRename(delay);

        public void EndRename_Internal(bool acceptChanges)
        {
            EndRename(acceptChanges);
        }

        public void RenameEnded_Internal()
        {
            RenameEnded();
        }

        public void ClearRenameState_Internal()
        {
            ClearRenameState();
        }

        public void HandleRenameOverlay_Internal()
        {
            HandleRenameOverlay();
        }

        public bool IsSelected_Internal(int instanceID) => IsSelected(instanceID);

        public int[] GetSelection_Internal() => GetSelection();

        public bool IsLastClickedItemVisible_Internal() => IsLastClickedItemVisible();

        public void SelectAll_Internal()
        {
            SelectAll();
        }

        public void SetSelection_Internal(int[] selectedInstanceIDs, bool doubleClicked)
        {
            SetSelection(selectedInstanceIDs, doubleClicked);
        }

        public void InitSelection_Internal(int[] selectedInstanceIDs)
        {
            InitSelection(selectedInstanceIDs);
        }

        public void HandleZoomScrolling_Internal()
        {
            HandleZoomScrolling();
        }

        public bool IsPreviewIconExpansionModifierPressed_Internal() => IsPreviewIconExpansionModifierPressed();

        public bool AllowLeftRightArrowNavigation_Internal() => AllowLeftRightArrowNavigation();

        public void HandleKeyboard_Internal(bool checkKeyboardControl)
        {
            HandleKeyboard(checkKeyboardControl);
        }

        public void DoOffsetSelectionSpecialKeys_Internal(int idx, int maxIndex)
        {
            DoOffsetSelectionSpecialKeys(idx, maxIndex);
        }

        public void DoOffsetSelection_Internal()
        {
            DoOffsetSelection();
        }

        public void OffsetSelection_Internal(int selectionOffset)
        {
            OffsetSelection(selectionOffset);
        }

        public void SelectFirst_Internal()
        {
            SelectFirst();
        }

        public void SetSelectedAssetByIdx_Internal(int selectedIdx)
        {
            SetSelectedAssetByIdx(selectedIdx);
        }

        public void Reveal_Internal(int instanceID)
        {
            Reveal(instanceID);
        }

        public bool Frame_Internal(int instanceID, bool frame, bool ping) => Frame(instanceID, frame, ping);

        public int GetSelectedAssetIdx_Internal() => GetSelectedAssetIdx();

        public bool SkipGroup_Internal(ObjectListGroup_Internal group) => SkipGroup(group.Target_Internal);

        public int GetMaxIdx_Internal() => GetMaxIdx();

        public bool IsLocalAssetsCurrentlySelected_Internal() => IsLocalAssetsCurrentlySelected();

        public void SetupData_Internal(bool forceReflow)
        {
            SetupData(forceReflow);
        }

        public bool IsObjectSelector_Internal() => IsObjectSelector();

        public void HandleListArea_Internal()
        {
            HandleListArea();
        }

        public bool IsListMode_Internal() => IsListMode();

        public void Reflow_Internal()
        {
            Reflow();
        }

        public void UpdateGroupSizes_Internal(ObjectListGroup_Internal group)
        {
            UpdateGroupSizes(group.Target_Internal);
        }

        public int GetMaxNumVisibleItems_Internal() => GetMaxNumVisibleItems();

        public static Rect AdjustRectForFraming_Internal(Rect rect) => AdjustRectForFraming(rect);

        public void CenterRect_Internal(Rect rect)
        {
            CenterRect(rect);
        }

        public void ScrollToPosition_Internal(Rect rect)
        {
            ScrollToPosition(rect);
        }

        public void OnInspectorUpdate_Internal()
        {
            OnInspectorUpdate();
        }

        public void ClearCroppedLabelCache_Internal()
        {
            ClearCroppedLabelCache();
        }

        public string GetCroppedLabelText_Internal(AssetReference_Internal assetReference, string fullText, float cropWidth)
        {
            return GetCroppedLabelText(assetReference.Target_Internal, fullText, cropWidth);
        }

        public bool IsShowing_Internal(int instanceID) => IsShowing(instanceID);

        public bool IsShowingAny_Internal(int[] instanceIDs) => IsShowingAny(instanceIDs);

        public Texture GetIconByInstanceID_Internal(int instanceID) => GetIconByInstanceID(instanceID);

        public int GetAssetPreviewManagerID_Internal() => GetAssetPreviewManagerID();

        public void BeginPing_Internal(int instanceID)
        {
            BeginPing(instanceID);
        }

        public void EndPing_Internal()
        {
            EndPing();
        }

        public void HandlePing_Internal()
        {
            HandlePing();
        }

        public Vector2 CalculatePingPosition_Internal() => CalculatePingPosition();

        private static readonly Dictionary<OnAssetIconDrawDelegate_Internal, OnAssetIconDrawDelegate> postAssetIconDrawMap =
            new Dictionary<OnAssetIconDrawDelegate_Internal, OnAssetIconDrawDelegate>();

        public static event OnAssetIconDrawDelegate_Internal postAssetIconDrawCallback_Internal
        {
            add
            {
                if (postAssetIconDrawMap.ContainsKey(value))
                    return;

                OnAssetIconDrawDelegate action = (iconRect, guid, isListMode) => value(iconRect, guid, isListMode);
                postAssetIconDrawMap[value] = action;
                postAssetIconDrawCallback += action;
            }
            remove
            {
                if (!postAssetIconDrawMap.TryGetValue(value, out OnAssetIconDrawDelegate action))
                    return;

                postAssetIconDrawCallback -= action;
                postAssetIconDrawMap.Remove(value);
            }
        }

        private static readonly Dictionary<OnAssetLabelDrawDelegate_Internal, OnAssetLabelDrawDelegate> postAssetLabelDrawMap =
            new Dictionary<OnAssetLabelDrawDelegate_Internal, OnAssetLabelDrawDelegate>();

        public static event OnAssetLabelDrawDelegate_Internal postAssetLabelDrawCallback_Internal
        {
            add
            {
                if (postAssetLabelDrawMap.ContainsKey(value))
                    return;

                OnAssetLabelDrawDelegate action = (drawRect, guid, isListMode) => value(drawRect, guid, isListMode);
                postAssetLabelDrawMap[value] = action;
                postAssetLabelDrawCallback += action;
            }
            remove
            {
                if (!postAssetLabelDrawMap.TryGetValue(value, out OnAssetLabelDrawDelegate action))
                    return;

                postAssetLabelDrawCallback -= action;
                postAssetLabelDrawMap.Remove(value);
            }
        }
    }
}
