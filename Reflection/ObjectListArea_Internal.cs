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


        public static bool s_Debug_Internal
        {
            get => s_Debug;
            set => s_Debug = value;
        }

        public ObjectListArea_Internal(ObjectListAreaState_Internal state, EditorWindow owner, bool showNoneItem) : base(state, owner, showNoneItem) { }

        public float m_SpaceBetween_Internal
        {
            get => this.m_SpaceBetween;
            set => this.m_SpaceBetween = value;
        }

        public float m_TopMargin_Internal
        {
            get => this.m_TopMargin;
            set => this.m_TopMargin = value;
        }

        public float m_BottomMargin_Internal
        {
            get => this.m_BottomMargin;
            set => this.m_BottomMargin = value;
        }

        public float m_RightMargin_Internal
        {
            get => this.m_RightMargin;
            set => this.m_RightMargin = value;
        }

        public float m_LeftMargin_Internal
        {
            get => this.m_LeftMargin;
            set => this.m_LeftMargin = value;
        }

        public bool allowDragging_Internal
        {
            get => this.allowDragging;
            set => this.allowDragging = value;
        }

        public bool allowRenaming_Internal
        {
            get => this.allowRenaming;
            set => this.allowRenaming = value;
        }

        public bool allowMultiSelect_Internal
        {
            get => this.allowMultiSelect;
            set => this.allowMultiSelect = value;
        }

        public bool allowDeselection_Internal
        {
            get => this.allowDeselection;
            set => this.allowDeselection = value;
        }

        public bool allowFocusRendering_Internal
        {
            get => this.allowFocusRendering;
            set => this.allowFocusRendering = value;
        }

        public bool allowBuiltinResources_Internal
        {
            get => this.allowBuiltinResources;
            set => this.allowBuiltinResources = value;
        }

        public bool allowUserRenderingHook_Internal
        {
            get => this.allowUserRenderingHook;
            set => this.allowUserRenderingHook = value;
        }

        public bool allowFindNextShortcut_Internal
        {
            get => this.allowFindNextShortcut;
            set => this.allowFindNextShortcut = value;
        }

        public bool foldersFirst_Internal
        {
            get => this.foldersFirst;
            set => this.foldersFirst = value;
        }

        public Action repaintCallback_Internal
        {
            get => this.m_RepaintWantedCallback;
            set => this.m_RepaintWantedCallback = value;
        }

        public Action<bool> itemSelectedCallback_Internal
        {
            get => this.m_ItemSelectedCallback;
            set => this.m_ItemSelectedCallback = value;
        }

        public Action keyboardCallback_Internal
        {
            get => this.m_KeyboardInputCallback;
            set => this.m_KeyboardInputCallback = value;
        }

        public Action gotKeyboardFocus_Internal
        {
            get => this.m_GotKeyboardFocus;
            set => this.m_GotKeyboardFocus = value;
        }

        public Func<Rect, float> drawLocalAssetHeader_Internal
        {
            get => this.m_DrawLocalAssetHeader;
            set => this.m_DrawLocalAssetHeader = value;
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
            SearchSessionOptions searchSessionOptions)
        {
            Init(rect, hierarchyType, searchFilter, checkThumbnails, searchSessionOptions);
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
            SearchSessionOptions searchSessionOptions)
        {
            InitForSearch(rect, hierarchyType, searchFilter, checkThumbnails, assetToInstanceId, searchSessionOptions);
        }

        public float GetVisibleWidth_Internal() => GetVisibleWidth();

        public void OnGUI_Internal(Rect position, int keyboardControlID)
        {
            OnGUI(position, keyboardControlID);
        }

        public bool CanShowThumbnails_Internal() => CanShowThumbnails();

        public int gridSize_Internal
        {
            get => this.gridSize;
            set => this.gridSize = value;
        }

        public int minGridSize_Internal => this.m_MinGridSize;

        public int maxGridSize_Internal => this.m_MaxGridSize;

        public int numItemsDisplayed_Internal => this.m_LocalAssets.ItemCount;

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

        public void InitSelection_Internal(int[] selectedInstanceIDs)
        {
            InitSelection(selectedInstanceIDs);
        }

        public void HandleKeyboard_Internal(bool checkKeyboardControl)
        {
            HandleKeyboard(checkKeyboardControl);
        }

        public void OffsetSelection_Internal(int selectionOffset)
        {
            OffsetSelection(selectionOffset);
        }

        public void SelectFirst_Internal()
        {
            SelectFirst();
        }

        public bool Frame_Internal(int instanceID, bool frame, bool ping) => Frame(instanceID, frame, ping);

        public void OnInspectorUpdate_Internal()
        {
            OnInspectorUpdate();
        }

        public bool IsShowing_Internal(int instanceID) => IsShowing(instanceID);

        public bool IsShowingAny_Internal(int[] instanceIDs) => IsShowingAny(instanceIDs);

        public int GetAssetPreviewManagerID_Internal() => GetAssetPreviewManagerID();

        public void BeginPing_Internal(int instanceID)
        {
            BeginPing(instanceID);
        }

        public void EndPing_Internal()
        {
            EndPing();
        }


        private static Dictionary<OnAssetIconDrawDelegate_Internal, OnAssetIconDrawDelegate> postAssetIconDrawMap =
            new Dictionary<OnAssetIconDrawDelegate_Internal, OnAssetIconDrawDelegate>();

        public static event OnAssetIconDrawDelegate_Internal postAssetIconDrawCallback_Internal
        {
            add
            {
                if (postAssetIconDrawMap.ContainsKey(value)) return;

                OnAssetIconDrawDelegate action = (iconRect, guid, isListMode) => value(iconRect, guid, isListMode);
                postAssetIconDrawMap[value] = action;
                postAssetIconDrawCallback += action;
            }
            remove
            {
                if (postAssetIconDrawMap.TryGetValue(value, out OnAssetIconDrawDelegate action) == false) return;
                postAssetIconDrawCallback -= action;
                postAssetIconDrawMap.Remove(value);
            }
        }


        private static Dictionary<OnAssetLabelDrawDelegate_Internal, OnAssetLabelDrawDelegate> postAssetLabelDrawMap =
            new Dictionary<OnAssetLabelDrawDelegate_Internal, OnAssetLabelDrawDelegate>();

        public static event OnAssetLabelDrawDelegate_Internal postAssetLabelDrawCallback_Internal
        {
            add
            {
                if (postAssetLabelDrawMap.ContainsKey(value)) return;

                OnAssetLabelDrawDelegate action = (drawRect, guid, isListMode) => value(drawRect, guid, isListMode);
                postAssetLabelDrawMap[value] = action;
                postAssetLabelDrawCallback += action;
            }
            remove
            {
                if (postAssetLabelDrawMap.TryGetValue(value, out OnAssetLabelDrawDelegate action) == false) return;
                postAssetLabelDrawCallback -= action;
                postAssetLabelDrawMap.Remove(value);
            }
        }
    }
}