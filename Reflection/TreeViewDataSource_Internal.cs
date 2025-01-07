using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;

namespace Emilia.Reflection.Editor
{
    public abstract class TreeViewDataSource_Internal : TreeViewDataSource
    {
        protected TreeViewDataSource_Internal(TreeViewController_Internals treeView) : base(treeView) { }

        public override void FetchData()
        {
            FetchData_Internal();
        }

        public abstract void FetchData_Internal();

        public override List<int> GetNewSelection(TreeViewItem clickedItem, TreeViewSelectState selectState)
        {
            return GetNewSelection_Internal(clickedItem, new TreeViewSelectState_Internals(selectState));
        }

        public abstract List<int> GetNewSelection_Internal(TreeViewItem clickedItem, TreeViewSelectState_Internals selectState);
    }
}