using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UIElements;

namespace Emilia.Reflection.Editor
{
    public class GraphView_Internals : GraphView
    {
        public ContentZoomer zoomer_Internal
        {
            get => m_Zoomer;
            set => m_Zoomer = value;
        }
        
        public float minScale_Internal
        {
            get => m_MinScale;
            set => m_MinScale = value;
        }
        
        public float maxScale_Internal
        {
            get => m_MaxScale;
            set => m_MaxScale = value;
        }
        
        public string clipboard_Internal
        {
            get => clipboard;
            set => clipboard = value;
        }
        
        public void UpdatePersistedViewTransform_Internals()
        {
            UpdatePersistedViewTransform();
        }

        public void RequestNodeCreation_Internals(VisualElement target, int index, Vector2 position)
        {
            RequestNodeCreation(target, index, position);
        }

        public void CutSelectionCallback_Internals()
        {
            CutSelectionCallback();
        }

        public void CopySelectionCallback_Internals()
        {
            CopySelectionCallback();
        }

        public void PasteCallback_Internals()
        {
            PasteCallback();
        }

        public void DeleteSelectionCallback_Internals()
        {
            DeleteSelectionCallback(AskUser.DontAskUser);
        }

        public void DuplicateSelectionCallback_Internals()
        {
            DuplicateSelectionCallback();
        }
    }
}