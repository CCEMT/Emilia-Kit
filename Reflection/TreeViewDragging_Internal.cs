using System.Collections.Generic;
using UnityEditor;
using UnityEditor.IMGUI.Controls;

namespace Emilia.Reflection.Editor
{
    public class TreeViewDragging_Internal : TreeViewDragging
    {
        public TreeViewDragging_Internal(TreeViewController treeView) : base(treeView) { }

        public override void StartDrag(TreeViewItem draggedItem, List<int> draggedItemIDs)
        {
            StartDrag_Internal(draggedItem, draggedItemIDs);
        }

        public virtual void StartDrag_Internal(TreeViewItem draggedItem, List<int> draggedItemIDs) { }

        public override DragAndDropVisualMode DoDrag(TreeViewItem parentItem, TreeViewItem targetItem, bool perform, DropPosition dropPosition)
        {
            return DoDrag_Internal(parentItem, targetItem, perform, dropPosition);
        }

        public virtual DragAndDropVisualMode DoDrag_Internal(TreeViewItem parentItem, TreeViewItem targetItem, bool perform, DropPosition dropPosition)
        {
            return default;
        }
    }
}