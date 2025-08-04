using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public class TreeViewController_Internals : TreeViewController
    {
        public static double kSlowSelectTimeout_Internal => kSlowSelectTimeout;
        public static float kSpaceForScrollBar_Internal => kSpaceForScrollBar;

        public TreeViewController_Internals(EditorWindow editorWindow, TreeViewState treeViewState) : base(editorWindow, treeViewState) { }

        public Action<int[]> selectionChangedCallback_Internal
        {
            get => selectionChangedCallback;
            set => selectionChangedCallback = value;
        }

        public Action<int> itemSingleClickedCallback_Internal
        {
            get => itemSingleClickedCallback;
            set => itemSingleClickedCallback = value;
        }

        public Action<int> itemDoubleClickedCallback_Internal
        {
            get => itemDoubleClickedCallback;
            set => itemDoubleClickedCallback = value;
        }

        public Action<int[], bool> dragEndedCallback_Internal
        {
            get => dragEndedCallback;
            set => dragEndedCallback = value;
        }

        public Action<int> contextClickItemCallback_Internal
        {
            get => contextClickItemCallback;
            set => contextClickItemCallback = value;
        }

        public Action contextClickOutsideItemsCallback_Internal
        {
            get => contextClickOutsideItemsCallback;
            set => contextClickOutsideItemsCallback = value;
        }

        public Action keyboardInputCallback_Internal
        {
            get => keyboardInputCallback;
            set => keyboardInputCallback = value;
        }

        public Action expandedStateChanged_Internal
        {
            get => expandedStateChanged;
            set => expandedStateChanged = value;
        }

        public Action<string> searchChanged_Internal
        {
            get => searchChanged;
            set => searchChanged = value;
        }

        public Action<Vector2> scrollChanged_Internal
        {
            get => scrollChanged;
            set => scrollChanged = value;
        }

        public Action<int, Rect> onGUIRowCallback_Internal
        {
            get => onGUIRowCallback;
            set => onGUIRowCallback = value;
        }

        public Action<int, Rect> onFoldoutButton_Internal
        {
            get => onFoldoutButton;
            set => onFoldoutButton = value;
        }

        public ITreeViewDataSource_Internal data_Internal
        {
            get => data as ITreeViewDataSource_Internal;
            set => data = value;
        }

        public ITreeViewDragging_Internal dragging_Internal
        {
            get => dragging as ITreeViewDragging_Internal;
            set => dragging = value;
        }

        public ITreeViewGUI_Internal gui_Internal
        {
            get => gui as ITreeViewGUI_Internal;
            set => gui = value;
        }

        public TreeViewState state_Internal
        {
            get => state;
            set => state = value;
        }

        public GUIStyle horizontalScrollbarStyle_Internal
        {
            get => horizontalScrollbarStyle;
            set => horizontalScrollbarStyle = value;
        }

        public GUIStyle verticalScrollbarStyle_Internal
        {
            get => verticalScrollbarStyle;
            set => verticalScrollbarStyle = value;
        }

        public GUIStyle scrollViewStyle_Internal
        {
            get => scrollViewStyle;
            set => scrollViewStyle = value;
        }

        public object expansionAnimator_Internal => expansionAnimator;

        public bool deselectOnUnhandledMouseDown_Internal
        {
            get => deselectOnUnhandledMouseDown;
            set => deselectOnUnhandledMouseDown = value;
        }

        public bool enableItemHovering_Internal
        {
            get => enableItemHovering;
            set => enableItemHovering = value;
        }

        public bool useExpansionAnimation_Internal
        {
            get => useExpansionAnimation;
            set => useExpansionAnimation = value;
        }

        public TreeViewItem hoveredItem_Internal
        {
            get => hoveredItem;
            set => hoveredItem = value;
        }

        public void Init_Internal(Rect rect, ITreeViewDataSource_Internal data, ITreeViewGUI_Internal gui, ITreeViewDragging_Internal dragging)
        {
            Init(rect, data, gui, dragging);
        }

        public bool isSearching_Internal => isSearching;

        public bool isDragging_Internal => isDragging;

        public bool IsDraggingItem_Internal(TreeViewItem item) => IsDraggingItem(item);

        public bool showingVerticalScrollBar_Internal => showingVerticalScrollBar;

        public bool showingHorizontalScrollBar_Internal => showingHorizontalScrollBar;

        public string searchString_Internal
        {
            get => searchString;
            set => searchString = value;
        }

        public bool useScrollViewInternal
        {
            get => useScrollView;
            set => useScrollView = value;
        }

        public bool grabKeyboardFocus_Internal
        {
            get => m_GrabKeyboardFocus;
            set => m_GrabKeyboardFocus = value;
        }

        public Rect totalRect_Internal
        {
            get => m_TotalRect;
            set => m_TotalRect = value;
        }

        public Rect visibleRect_Internal
        {
            get => this.m_VisibleRect;
            set => this.m_VisibleRect = value;
        }

        public Rect contentRect_Internal
        {
            get => m_ContentRect;
            set => m_ContentRect = value;
        }

        public bool hadFocusLastEvent_Internal
        {
            get => m_HadFocusLastEvent;
            set => m_HadFocusLastEvent = value;
        }

        public int m_KeyboardControlID_Internal
        {
            get => m_KeyboardControlID;
            set => m_KeyboardControlID = value;
        }

        public bool IsSelected_Internal(int id) => IsSelected(id);

        public bool HasSelection_Internal() => HasSelection();

        public int[] GetSelection_Internal() => GetSelection();

        public int[] GetRowIDs_Internal() => GetRowIDs();

        public void SetSelection_Internal(int[] selectedIDs, bool revealSelectionAndFrameLastSelected)
        {
            SetSelection(selectedIDs, revealSelectionAndFrameLastSelected);
        }

        public void SetSelection_Internal(int[] selectedIDs, bool revealSelectionAndFrameLastSelected, bool animatedFraming)
        {
            SetSelection(selectedIDs, revealSelectionAndFrameLastSelected, animatedFraming);
        }

        public TreeViewItem FindItem_Internal(int id) => FindItem(id);

        public void SetConsumeKeyDownEvents_Internal(bool consume)
        {
            SetConsumeKeyDownEvents(consume);
        }

        public void Repaint_Internal()
        {
            Repaint();
        }

        public void ReloadData_Internal()
        {
            ReloadData();
        }

        public bool HasFocus_Internal() => HasFocus();

        public static int GetItemControlID_Internal(TreeViewItem item) => GetItemControlID(item);

        public void HandleUnusedMouseEventsForItem_Internal(Rect rect, TreeViewItem item, int row)
        {
            HandleUnusedMouseEventsForItem(rect, item, row);
        }

        public void GrabKeyboardFocus_Internal()
        {
            GrabKeyboardFocus();
        }

        public void NotifyListenersThatSelectionChanged_Internal()
        {
            NotifyListenersThatSelectionChanged();
        }

        public void NotifyListenersThatDragEnded_Internal(int[] draggedIDs, bool draggedItemsFromOwnTreeView)
        {
            NotifyListenersThatDragEnded(draggedIDs, draggedItemsFromOwnTreeView);
        }

        public Vector2 GetContentSize_Internal() => GetContentSize();

        public Rect GetTotalRect_Internal() => GetTotalRect();

        public void SetTotalRect_Internal(Rect rect)
        {
            SetTotalRect(rect);
        }

        public bool IsItemDragSelectedOrSelected_Internal(TreeViewItem item) => IsItemDragSelectedOrSelected(item);

        public bool animatingExpansion_Internal => animatingExpansion;

        public void DoItemGUI_Internal(TreeViewItem item, int row, float rowWidth, bool hasFocus)
        {
            DoItemGUI(item, row, rowWidth, hasFocus);
        }

        public void OnGUI_Internal(Rect rect, int keyboardControlID)
        {
            OnGUI(rect, keyboardControlID);
        }

        public void HandleTreeViewGotFocus_Internal(bool isMouseDownInTotalRect)
        {
            HandleTreeViewGotFocus(isMouseDownInTotalRect);
        }

        public void IterateVisibleItems_Internal(int firstRow, int numVisibleRows, float rowWidth, bool hasFocus)
        {
            IterateVisibleItems(firstRow, numVisibleRows, rowWidth, hasFocus);
        }

        public void ExpansionAnimationEnded_Internal(TreeViewAnimationInput_Internal setup)
        {
            ExpansionAnimationEnded(setup.value);
        }

        public float GetAnimationDuration_Internal(float height) => GetAnimationDuration(height);

        public void UserInputChangedExpandedState_Internal(TreeViewItem item, int row, bool expand)
        {
            UserInputChangedExpandedState(item, row, expand);
        }

        public void ChangeExpandedState_Internal(TreeViewItem item, bool expand, bool includeChildren)
        {
            ChangeExpandedState(item, expand, includeChildren);
        }

        public int GetLastChildRowUnder_Internal(int row) => GetLastChildRowUnder(row);

        protected override Rect GetRectForRows(int startRow, int endRow, float rowWidth) => GetRectForRows_Internal(startRow, endRow, rowWidth);

        public virtual Rect GetRectForRows_Internal(int startRow, int endRow, float rowWidth) => base.GetRectForRows(startRow, endRow, rowWidth);

        public void HandleUnusedEvents_Internal()
        {
            HandleUnusedEvents();
        }

        public void OnEvent_Internal()
        {
            OnEvent();
        }

        public bool BeginNameEditing_Internal(float delay) => BeginNameEditing(delay);

        public void EndNameEditing_Internal(bool acceptChanges)
        {
            EndNameEditing(acceptChanges);
        }

        public TreeViewItem GetItemAndRowIndex_Internal(int id, out int row) => GetItemAndRowIndex(id, out row);

        public void HandleFastCollapse_Internal(TreeViewItem item, int row)
        {
            HandleFastCollapse(item, row);
        }

        public void HandleFastExpand_Internal(TreeViewItem item, int row)
        {
            HandleFastExpand(item, row);
        }

        public void ChangeFolding_Internal(int[] ids, bool expand)
        {
            ChangeFolding(ids, expand);
        }

        public void ChangeFoldingForSingleItem_Internal(int id, bool expand)
        {
            ChangeFoldingForSingleItem(id, expand);
        }

        public void ChangeFoldingForMultipleItems_Internal(int[] ids, bool expand)
        {
            ChangeFoldingForMultipleItems(ids, expand);
        }

        public void KeyboardGUI_Internal()
        {
            KeyboardGUI();
        }

        public static int GetIndexOfID_Internal(IList<TreeViewItem> items, int id) => GetIndexOfID(items, id);

        public bool IsLastClickedPartOfRows_Internal() => IsLastClickedPartOfRows();

        public void OffsetSelection_Internal(int offset)
        {
            OffsetSelection(offset);
        }

        public Func<TreeViewItem, bool, bool, List<int>> getNewSelectionOverride_Internal
        {
            set => getNewSelectionOverride = value;
        }

        public List<int> GetNewSelection_Internal(TreeViewItem clickedItem, bool keepMultiSelection, bool useShiftAsActionKey) => GetNewSelection(clickedItem, keepMultiSelection, useShiftAsActionKey);

        public void SelectionByKey_Internal(TreeViewItem itemSelected)
        {
            SelectionByKey(itemSelected);
        }

        public void SelectionClick_Internal(TreeViewItem itemClicked, bool keepMultiSelection)
        {
            SelectionClick(itemClicked, keepMultiSelection);
        }

        public void NewSelectionFromUserInteraction_Internal(List<int> newSelection, int itemID)
        {
            NewSelectionFromUserInteraction(newSelection, itemID);
        }

        public void RemoveSelection_Internal()
        {
            RemoveSelection();
        }

        public float GetTopPixelOfRow_Internal(int row) => GetTopPixelOfRow(row);

        public void EnsureRowIsVisible_Internal(int row, bool animated)
        {
            EnsureRowIsVisible(row, animated);
        }

        public void AnimatedScrollChanged_Internal()
        {
            AnimatedScrollChanged();
        }

        public void ChangeScrollValue_Internal(float targetScrollPos, bool animated)
        {
            ChangeScrollValue(targetScrollPos, animated);
        }

        public void Frame_Internal(int id, bool frame, bool ping)
        {
            Frame(id, frame, ping);
        }

        public void Frame_Internal(int id, bool frame, bool ping, bool animated)
        {
            Frame(id, frame, ping, animated);
        }

        public void EndPing_Internal()
        {
            EndPing();
        }

        public List<int> SortIDsInVisiblityOrder_Internal(IList<int> ids) => SortIDsInVisiblityOrder(ids);
    }
}