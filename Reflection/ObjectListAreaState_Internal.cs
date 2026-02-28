using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public class ObjectListAreaState_Internal : ObjectListAreaState
    {
        public List<int> m_SelectedInstanceIDs_Internal
        {
            get => this.m_SelectedInstanceIDs;
            set => this.m_SelectedInstanceIDs = value;
        }

        public int m_LastClickedInstanceID_Internal
        {
            get => this.m_LastClickedInstanceID;
            set => this.m_LastClickedInstanceID = value;
        }

        public bool m_HadKeyboardFocusLastEvent_Internal
        {
            get => this.m_HadKeyboardFocusLastEvent;
            set => this.m_HadKeyboardFocusLastEvent = value;
        }

        public List<int> m_ExpandedInstanceIDs_Internal
        {
            get => this.m_ExpandedInstanceIDs;
            set => this.m_ExpandedInstanceIDs = value;
        }

        public RenameOverlay m_RenameOverlay_Internal
        {
            get => this.m_RenameOverlay;
            set => this.m_RenameOverlay = value;
        }

        public CreateAssetUtility m_CreateAssetUtility_Internal
        {
            get => this.m_CreateAssetUtility;
            set => this.m_CreateAssetUtility = value;
        }

        public int m_NewAssetIndexInList_Internal
        {
            get => this.m_NewAssetIndexInList;
            set => this.m_NewAssetIndexInList = value;
        }

        public Vector2 m_ScrollPosition_Internal
        {
            get => this.m_ScrollPosition;
            set => this.m_ScrollPosition = value;
        }

        public int m_GridSize_Internal
        {
            get => this.m_GridSize;
            set => this.m_GridSize = value;
        }

        public void OnAwake_Internal() => OnAwake();
    }
}