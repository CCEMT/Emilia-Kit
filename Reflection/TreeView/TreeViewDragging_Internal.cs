using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public class TreeViewDragging_Internal : TreeViewDragging, ITreeViewDragging_Internal
    {
        public enum DropPosition_Internal
        {
            Upon,
            Below,
            Above,
        }

        public struct DropData_Internal
        {
            private DropData dropData;

            public int[] expandedArrayBeforeDrag_Internal => dropData.expandedArrayBeforeDrag;
            public int lastControlID_Internal => dropData.lastControlID;
            public int dropTargetControlID_Internal => dropData.dropTargetControlID;
            public int rowMarkerControlID_Internal => dropData.rowMarkerControlID;
            public int ancestorControlID_Internal => dropData.ancestorControlID;
            public double expandItemBeginTimer_Internal => dropData.expandItemBeginTimer;
            public Vector2 expandItemBeginPosition_Internal => dropData.expandItemBeginPosition;
            public float insertionMarkerYPosition_Internal => dropData.insertionMarkerYPosition;
            public TreeViewItem insertRelativeToSibling_Internal => dropData.insertRelativeToSibling;

            public DropData_Internal(DropData dropData)
            {
                this.dropData = dropData;
            }

            public void ClearPerEventState_Internal()
            {
                dropData.ClearPerEventState();
            }
        }

        public DropData_Internal dropData_Internal => new DropData_Internal(m_DropData);

        public Func<int> getIndentLevelForMouseCursor_Internal
        {
            get => getIndentLevelForMouseCursor;
            set => getIndentLevelForMouseCursor = value;
        }

        public TreeViewDragging_Internal(TreeViewController_Internals treeView) : base(treeView) { }

        public override void OnInitialize()
        {
            OnInitialize_Internal();
        }

        public virtual void OnInitialize_Internal() { }

        public int GetDropTargetControlID_Internal() => GetDropTargetControlID();

        public int GetRowMarkerControlID_Internal() => GetRowMarkerControlID();

        public int GetAncestorControlID_Internal() => GetAncestorControlID();

        public bool drawRowMarkerAbove_Internal
        {
            get => drawRowMarkerAbove;
            set => drawRowMarkerAbove = value;
        }

        public float insertionMarkerYPosition_Internal => insertionMarkerYPosition;

        public TreeViewItem insertRelativeToSibling_Internal => insertRelativeToSibling;

        public override bool CanStartDrag(TreeViewItem targetItem, List<int> draggedItemIDs, Vector2 mouseDownPosition) => CanStartDrag_Internal(targetItem, draggedItemIDs, mouseDownPosition);

        public virtual bool CanStartDrag_Internal(TreeViewItem targetItem, List<int> draggedItemIDs, Vector2 mouseDownPosition) => base.CanStartDrag(targetItem, draggedItemIDs, mouseDownPosition);

        public override void StartDrag(TreeViewItem draggedItem, List<int> draggedItemIDs)
        {
            StartDrag_Internal(draggedItem, draggedItemIDs);
        }

        public virtual void StartDrag_Internal(TreeViewItem draggedItem, List<int> draggedItemIDs) { }

        public override bool DragElement(TreeViewItem targetItem, Rect targetItemRect, int row) => DragElement_Internal(targetItem, targetItemRect, row);

        public virtual bool DragElement_Internal(TreeViewItem targetItem, Rect targetItemRect, int row) => base.DragElement(targetItem, targetItemRect, row);

        public override DragAndDropVisualMode DoDrag(TreeViewItem parentItem, TreeViewItem targetItem, bool perform, DropPosition dropPosition) =>
            DoDrag_Internal(parentItem, targetItem, perform, (DropPosition_Internal) dropPosition);

        public virtual DragAndDropVisualMode DoDrag_Internal(TreeViewItem parentItem, TreeViewItem targetItem, bool perform, DropPosition_Internal dropPosition) => default;

        public override void DragCleanup(bool revertExpanded)
        {
            DragCleanup_Internal(revertExpanded);
        }

        public void DragCleanup_Internal(bool revertExpanded)
        {
            base.DragCleanup(revertExpanded);
        }

        public override void HandleAutoExpansion(int itemControlID, TreeViewItem targetItem, Rect targetItemRect)
        {
            HandleAutoExpansion_Internal(itemControlID, targetItem, targetItemRect);
        }

        public virtual void HandleAutoExpansion_Internal(int itemControlID, TreeViewItem targetItem, Rect targetItemRect)
        {
            base.HandleAutoExpansion(itemControlID, targetItem, targetItemRect);
        }

        public void GetPreviousAndNextItemsIgnoringDraggedItems_Internal(int targetRow, DropPosition_Internal dropPosition, out TreeViewItem previousItem, out TreeViewItem nextItem)
        {
            GetPreviousAndNextItemsIgnoringDraggedItems(targetRow, (DropPosition) dropPosition, out previousItem, out nextItem);
        }

        public void HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded_Internal(
            ref TreeViewItem targetItem,
            int targetItemRow,
            ref DropPosition_Internal dropPosition_Internal,
            int cursorDepth,
            out bool didChangeTargetToAncestor)
        {
            DropPosition dropPosition = (DropPosition) dropPosition_Internal;

            HandleSiblingInsertionAtAvailableDepthsAndChangeTargetIfNeeded(
                ref targetItem,
                targetItemRow,
                ref dropPosition,
                cursorDepth,
                out didChangeTargetToAncestor);

            dropPosition_Internal = (DropPosition_Internal) dropPosition;
        }

        public bool TryGetDropPosition_Internal(
            TreeViewItem item,
            Rect itemRect,
            int row,
            out DropPosition_Internal dropPosition_Internal)
        {
            var result = TryGetDropPosition(item, itemRect, row, out var dropPosition);
            dropPosition_Internal = (DropPosition_Internal) dropPosition;
            return result;
        }

        public void FinalizeDragPerformed_Internal(bool revertExpanded)
        {
            FinalizeDragPerformed(revertExpanded);
        }

        public List<int> GetCurrentExpanded_Internal() => GetCurrentExpanded();

        public void RestoreExpanded_Internal(List<int> ids)
        {
            RestoreExpanded(ids);
        }

        public static int GetInsertionIndex(
            TreeViewItem parentItem,
            TreeViewItem targetItem,
            DropPosition_Internal dropPosition) =>
            GetInsertionIndex(parentItem, targetItem, (DropPosition) dropPosition);
    }
}