using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;

namespace Emilia.Reflection.Editor
{
    public struct TreeViewSelectState_Internals
    {
        private TreeViewSelectState _value;

        public List<int> selectedIDs => this._value.selectedIDs;
        public int lastClickedID => this._value.lastClickedID;
        public bool keepMultiSelection => this._value.keepMultiSelection;
        public bool useShiftAsActionKey => this._value.useShiftAsActionKey;

        public TreeViewSelectState value => this._value;

        public TreeViewSelectState_Internals(TreeViewSelectState value)
        {
            this._value = value;
        }
    }
}