using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public class TreeViewController_Internals : TreeViewController
    {
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

        public bool IsDraggingItem_Internal(TreeViewItem item)
        {
            return IsDraggingItem(item);
        }

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

        public Rect visibleRect_Internal => visibleRect;

        public bool IsSelected_Internal(int id)
        {
            return IsSelected(id);
        }

        public bool HasSelection_Internal()
        {
            return HasSelection();
        }

        public int[] GetSelection_Internal()
        {
            return GetSelection();
        }

        public int[] GetRowIDs_Internal()
        {
            return GetRowIDs();
        }

        public void SetSelection_Internal(int[] selectedIDs, bool revealSelectionAndFrameLastSelected)
        {
            SetSelection(selectedIDs, revealSelectionAndFrameLastSelected);
        }

        public void SetSelection_Internal(int[] selectedIDs, bool revealSelectionAndFrameLastSelected, bool animatedFraming)
        {
            SetSelection(selectedIDs, revealSelectionAndFrameLastSelected, animatedFraming);
        }

        public TreeViewItem FindItem_Internal(int id)
        {
            return FindItem(id);
        }

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

        public bool HasFocus_Internal()
        {
            return HasFocus();
        }

        public static int GetItemControlID_Internal(TreeViewItem item)
        {
            return GetItemControlID(item);
        }

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

        public Vector2 GetContentSize_Internal()
        {
            return GetContentSize();
        }

        public Rect GetTotalRect_Internal()
        {
            return GetTotalRect();
        }

        public void SetTotalRect_Internal(Rect rect)
        {
            SetTotalRect(rect);
        }

        public bool IsItemDragSelectedOrSelected_Internal(TreeViewItem item)
        {
            return IsItemDragSelectedOrSelected(item);
        }

        public bool animatingExpansion_Internal => animatingExpansion;

        public void OnGUI_Internal(Rect rect, int keyboardControlID)
        {
            OnGUI(rect, keyboardControlID);
        }

        public void UserInputChangedExpandedState_Internal(TreeViewItem item, int row, bool expand)
        {
            UserInputChangedExpandedState(item, row, expand);
        }

        public void ChangeExpandedState_Internal(TreeViewItem item, bool expand, bool includeChildren)
        {
            ChangeExpandedState(item, expand, includeChildren);
        }

        public void OnEvent_Internal()
        {
            OnEvent();
        }

        public bool BeginNameEditing_Internal(float delay)
        {
            return BeginNameEditing(delay);
        }

        public void EndNameEditing_Internal(bool acceptChanges)
        {
            EndNameEditing(acceptChanges);
        }

        public static int GetIndexOfID_Internal(IList<TreeViewItem> items, int id)
        {
            return GetIndexOfID(items, id);
        }

        public bool IsLastClickedPartOfRows_Internal()
        {
            return IsLastClickedPartOfRows();
        }

        public void OffsetSelection_Internal(int offset)
        {
            OffsetSelection(offset);
        }

        public Func<TreeViewItem, bool, bool, List<int>> getNewSelectionOverride_Internal
        {
            set => getNewSelectionOverride = value;
        }

        public void SelectionClick_Internal(TreeViewItem itemClicked, bool keepMultiSelection)
        {
            SelectionClick(itemClicked, keepMultiSelection);
        }

        public void RemoveSelection_Internal()
        {
            RemoveSelection();
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

        public List<int> SortIDsInVisiblityOrder_Internal(IList<int> ids)
        {
            return SortIDsInVisiblityOrder(ids);
        }
    }
}