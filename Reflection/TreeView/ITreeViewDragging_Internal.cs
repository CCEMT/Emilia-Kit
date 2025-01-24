using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public interface ITreeViewDragging_Internal : ITreeViewDragging
    {
        bool drawRowMarkerAbove_Internal { get; set; }
        void OnInitialize_Internal();

        bool CanStartDrag_Internal(TreeViewItem targetItem, List<int> draggedItemIDs, Vector2 mouseDownPosition);

        void StartDrag_Internal(TreeViewItem draggedItem, List<int> draggedItemIDs);

        bool DragElement_Internal(TreeViewItem targetItem, Rect targetItemRect, int row);

        void DragCleanup_Internal(bool revertExpanded);

        int GetDropTargetControlID_Internal();

        int GetRowMarkerControlID_Internal();
    }
}