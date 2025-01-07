using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;

namespace Emilia.Reflection.Editor
{
    public struct TreeViewSelectState_Internals
    {
        private TreeViewSelectState value;

        public List<int> selectedIDs => value.selectedIDs;
        public int lastClickedID => value.lastClickedID;
        public bool keepMultiSelection => value.keepMultiSelection;
        public bool useShiftAsActionKey => value.useShiftAsActionKey;

        public TreeViewSelectState_Internals(TreeViewSelectState value)
        {
            this.value = value;
        }
    }
}