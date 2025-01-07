using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;

namespace Emilia.Reflection.Editor
{
    public abstract class TreeViewDataSource_Internal : TreeViewDataSource
    {
        protected TreeViewDataSource_Internal(TreeViewController treeView) : base(treeView) { }

        public override List<int> GetNewSelection(TreeViewItem clickedItem, TreeViewSelectState selectState)
        {
            return GetNewSelection_Internal(clickedItem, new TreeViewSelectState_Internals(selectState));
        }

        protected abstract List<int> GetNewSelection_Internal(TreeViewItem clickedItem, TreeViewSelectState_Internals selectState);
    }
}