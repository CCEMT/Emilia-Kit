using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public static class SearchWindow_Extensions
    {
        public static void Init_Internals(this SearchWindow window, SearchWindowContext context, ScriptableObject provider)
        {
            window.Init(context, provider);
        }
    }

    public class SearchWindow_Internals : SearchWindow
    {
        public static SearchWindow filterWindow_Internal
        {
            get => s_FilterWindow;
            set => s_FilterWindow = value;
        }

        public static long lastClosedTime_Internal
        {
            get => s_LastClosedTime;
            set => s_LastClosedTime = value;
        }

        public static bool dirtyList_Internal
        {
            get => s_DirtyList;
            set => s_DirtyList = value;
        }

        public ScriptableObject owner_Internals
        {
            get => m_Owner;
            set => m_Owner = value;
        }

        public SearchWindowContext context_Internals
        {
            get => m_Context;
            set => m_Context = value;
        }

        public SearchTreeEntry[] tree_Internals
        {
            get => m_Tree;
            set => m_Tree = value;
        }

        public SearchTreeEntry[] searchResultTree_Internals
        {
            get => m_SearchResultTree;
            set => m_SearchResultTree = value;
        }

        public List<SearchTreeGroupEntry> selectionStack_Internals
        {
            get => m_SelectionStack;
            set => m_SelectionStack = value;
        }

        public float anim_Internals
        {
            get => m_Anim;
            set => m_Anim = value;
        }

        public int animTarget_Internals
        {
            get => m_AnimTarget;
            set => m_AnimTarget = value;
        }

        public long lastTime_Internals
        {
            get => m_LastTime;
            set => m_LastTime = value;
        }

        public bool scrollToSelected_Internals
        {
            get => m_ScrollToSelected;
            set => m_ScrollToSelected = value;
        }

        public string delayedSearch_Internals
        {
            get => m_DelayedSearch;
            set => m_DelayedSearch = value;
        }

        public string search_Internals
        {
            get => m_Search;
            set => m_Search = value;
        }

        public ISearchWindowProvider provider_Internals => provider;

        public bool hasSearch_Internals => hasSearch;

        public SearchTreeGroupEntry activeParent_Internals => activeParent;

        public SearchTreeEntry[] activeTree_Internals => activeTree;

        public SearchTreeEntry activeSearchTreeEntry_Internals => activeSearchTreeEntry;
        public bool isAnimating_Internals => isAnimating;

        public void Init_Internals(SearchWindowContext context, ScriptableObject provider)
        {
            Init(context, provider);
        }

        public SearchTreeGroupEntry GetSearchTreeEntryRelative_Internals(int rel) => GetSearchTreeEntryRelative(rel);

        public void GoToParent_Internals()
        {
            GoToParent();
        }

        public void SelectEntry_Internals(SearchTreeEntry e, bool shouldInvokeCallback)
        {
            SelectEntry(e, shouldInvokeCallback);
        }

        public List<SearchTreeEntry> GetChildren_Internals(SearchTreeEntry[] tree, SearchTreeEntry parent) => GetChildren(tree, parent);
    }
}