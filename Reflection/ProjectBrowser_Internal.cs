using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public struct ObjectListAreaStateHandle_Internal
    {
        private ObjectListAreaState _state;

        internal ObjectListAreaState Target_Internal => _state;

        public bool isValid_Internal => _state != null;

        public ObjectListAreaStateHandle_Internal(ObjectListAreaState state)
        {
            _state = state;
        }

        public List<int> m_SelectedInstanceIDs_Internal
        {
            get => _state.m_SelectedInstanceIDs;
            set => _state.m_SelectedInstanceIDs = value;
        }

        public int m_LastClickedInstanceID_Internal
        {
            get => _state.m_LastClickedInstanceID;
            set => _state.m_LastClickedInstanceID = value;
        }

        public bool m_HadKeyboardFocusLastEvent_Internal
        {
            get => _state.m_HadKeyboardFocusLastEvent;
            set => _state.m_HadKeyboardFocusLastEvent = value;
        }

        public List<int> m_ExpandedInstanceIDs_Internal
        {
            get => _state.m_ExpandedInstanceIDs;
            set => _state.m_ExpandedInstanceIDs = value;
        }

        public RenameOverlay_Internals m_RenameOverlay_Internal
        {
            get => new RenameOverlay_Internals(_state.m_RenameOverlay);
            set => _state.m_RenameOverlay = value.Target_Internal;
        }

        public CreateAssetUtility_Internal m_CreateAssetUtility_Internal
        {
            get => new CreateAssetUtility_Internal(_state.m_CreateAssetUtility);
            set => _state.m_CreateAssetUtility = value.Target_Internal;
        }

        public int m_NewAssetIndexInList_Internal
        {
            get => _state.m_NewAssetIndexInList;
            set => _state.m_NewAssetIndexInList = value;
        }

        public Vector2 m_ScrollPosition_Internal
        {
            get => _state.m_ScrollPosition;
            set => _state.m_ScrollPosition = value;
        }

        public int m_GridSize_Internal
        {
            get => _state.m_GridSize;
            set => _state.m_GridSize = value;
        }

        public void OnAwake_Internal()
        {
            _state.OnAwake();
        }
    }

    public struct ProjectBrowser_Internal
    {
        private ProjectBrowser _projectBrowser;

        internal ProjectBrowser Target_Internal => _projectBrowser;

        public bool isValid_Internal => _projectBrowser != null;

        public static Type projectBrowserType_Internal => typeof(ProjectBrowser);

        public static ProjectBrowser_Internal s_LastInteractedProjectBrowser_Internal
        {
            get => new ProjectBrowser_Internal(ProjectBrowser.s_LastInteractedProjectBrowser);
            set => ProjectBrowser.s_LastInteractedProjectBrowser = value.Target_Internal;
        }

        public static List<ProjectBrowser_Internal> s_ProjectBrowsers_Internal
        {
            get
            {
                if (ProjectBrowser.s_ProjectBrowsers == null)
                    return null;

                List<ProjectBrowser_Internal> result = new List<ProjectBrowser_Internal>(ProjectBrowser.s_ProjectBrowsers.Count);
                foreach (ProjectBrowser projectBrowser in ProjectBrowser.s_ProjectBrowsers)
                    result.Add(new ProjectBrowser_Internal(projectBrowser));
                return result;
            }
        }

        public ProjectBrowser_Internal(ProjectBrowser projectBrowser)
        {
            _projectBrowser = projectBrowser;
        }

        public static ProjectBrowser_Internal CreateInstance_Internal()
        {
            return new ProjectBrowser_Internal(ScriptableObject.CreateInstance(typeof(ProjectBrowser)) as ProjectBrowser);
        }

        public bool isFolderTreeViewContextClicked_Internal
        {
            get => _projectBrowser.isFolderTreeViewContextClicked;
            set => _projectBrowser.isFolderTreeViewContextClicked = value;
        }

        public ObjectListAreaStateHandle_Internal m_ListAreaState_Internal
        {
            get => new ObjectListAreaStateHandle_Internal(_projectBrowser.m_ListAreaState);
            set => _projectBrowser.m_ListAreaState = value.Target_Internal;
        }

        public string m_SearchFieldText_Internal
        {
            get => _projectBrowser.m_SearchFieldText;
            set => _projectBrowser.m_SearchFieldText = value;
        }

        public SearchFilter m_SearchFilter_Internal
        {
            get => _projectBrowser.m_SearchFilter;
            set => _projectBrowser.m_SearchFilter = value;
        }

        public string m_SelectedPath_Internal
        {
            get => _projectBrowser.m_SelectedPath;
            set => _projectBrowser.m_SelectedPath = value;
        }

        public void Init_Internal()
        {
            _projectBrowser.Init();
        }

        public bool Initialized_Internal() => _projectBrowser.Initialized();

        public void ShowFolderContents_Internal(int folderInstanceID, bool revealAndFrameInFolderTree)
        {
            _projectBrowser.ShowFolderContents(folderInstanceID, revealAndFrameInFolderTree);
        }
    }
}
