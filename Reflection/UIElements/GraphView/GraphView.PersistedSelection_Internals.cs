using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;

namespace Emilia.Reflection.Editor
{
    public struct GraphView_PersistedSelection_Internals
    {
        private GraphView.PersistedSelection _persistedSelection;

        public int version_Internal
        {
            get => this._persistedSelection.version;
            set => this._persistedSelection.version = value;
        }

        public HashSet<string> selectedElements_Internal => this._persistedSelection.selectedElements;

        public GraphView_PersistedSelection_Internals(GraphView.PersistedSelection persistedSelection)
        {
            this._persistedSelection = persistedSelection;
        }
    }
}