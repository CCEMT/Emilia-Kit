using System;
using UnityEditor.IMGUI.Controls;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public struct TreeViewAnimationInput_Internal
    {
        private TreeViewAnimationInput _value;

        public TreeViewAnimationInput value => this._value;

        public Action<TreeViewAnimationInput> animationEnded_Internal
        {
            get => this._value.animationEnded;
            set => this._value.animationEnded = value;
        }

        public float elapsedTimeNormalized_Internal => this._value.elapsedTimeNormalized;

        public double elapsedTime_Internal
        {
            get => this._value.elapsedTime;
            set => this._value.elapsedTime = value;
        }

        public int startRow_Internal
        {
            get => this._value.startRow;
            set => this._value.startRow = value;
        }

        public int endRow_Internal
        {
            get => this._value.endRow;
            set => this._value.endRow = value;
        }

        public Rect rowsRect_Internal
        {
            get => this._value.rowsRect;
            set => this._value.rowsRect = value;
        }

        public Rect startRowRect_Internal
        {
            get => this._value.startRowRect;
            set => this._value.startRowRect = value;
        }

        public double startTime_Internal
        {
            get => this._value.startTime;
            set => this._value.startTime = value;
        }

        public double timeCaptured_Internal
        {
            get => this._value.timeCaptured;
            set => this._value.timeCaptured = value;
        }

        public double animationDuration_Internal
        {
            get => this._value.animationDuration;
            set => this._value.animationDuration = value;
        }

        public bool expanding_Internal
        {
            get => this._value.expanding;
            set => this._value.expanding = value;
        }

        public bool includeChildren_Internal
        {
            get => this._value.includeChildren;
            set => this._value.includeChildren = value;
        }

        public TreeViewItem item_Internal
        {
            get => this._value.item;
            set => this._value.item = value;
        }

        public TreeViewController_Internals treeView_Internal
        {
            get => this._value.treeView as TreeViewController_Internals;
            set => this._value.treeView = value;
        }

        public TreeViewAnimationInput_Internal(TreeViewAnimationInput value)
        {
            _value = value;
            if (this._value == null) this._value = new TreeViewAnimationInput();
        }

        public void CaptureTime_Internal()
        {
            _value.CaptureTime();
        }

        public void FireAnimationEndedEvent_Internal()
        {
            _value.FireAnimationEndedEvent();
        }

        public override string ToString() => _value.ToString();
    }
}