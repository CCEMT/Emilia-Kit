using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;

namespace Emilia.Reflection.Editor
{
    public class TreeViewDataSource_Internal : TreeViewDataSource, ITreeViewDataSource_Internal
    {
        public TreeViewDataSource_Internal(TreeViewController_Internals treeView) : base(treeView) { }

        public override void FetchData()
        {
            FetchData_Internal();
        }

        public virtual void FetchData_Internal() { }

        public override List<int> GetNewSelection(TreeViewItem clickedItem, TreeViewSelectState selectState)
        {
            return GetNewSelection_Internal(clickedItem, new TreeViewSelectState_Internals(selectState));
        }

        public virtual List<int> GetNewSelection_Internal(TreeViewItem clickedItem, TreeViewSelectState_Internals selectState)
        {
            return default;
        }
    }
}