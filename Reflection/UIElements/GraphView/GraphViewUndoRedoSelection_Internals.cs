using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;

namespace Emilia.Reflection.Editor
{
    public struct GraphViewUndoRedoSelection_Internals
    {
        private GraphViewUndoRedoSelection _graphViewUndoRedoSelection;

        public int version_Internal
        {
            get => this._graphViewUndoRedoSelection.version;
            set => this._graphViewUndoRedoSelection.version = value;
        }

        public HashSet<string> selectedElements_Internal => this._graphViewUndoRedoSelection.selectedElements;

        public GraphViewUndoRedoSelection_Internals(GraphViewUndoRedoSelection graphViewUndoRedoSelection)
        {
            this._graphViewUndoRedoSelection = graphViewUndoRedoSelection;
        }
    }
}