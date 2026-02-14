using UnityEditor;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public struct RenameOverlay_Internals
    {
        private RenameOverlay target;

        public string name_Internal
        {
            get => target.name;
            set => target.name = value;
        }

        public string originalName_Internal => target.originalName;
        public bool userAcceptedRename_Internal => target.userAcceptedRename;
        public int userData_Internal => target.userData;
        public bool isWaitingForDelay_Internal => target.isWaitingForDelay;
        public Rect editFieldRect_Internal => target.editFieldRect;
        public bool isRenamingFilename_Internal => target.isRenamingFilename;

        public RenameOverlay_Internals(RenameOverlay renameOverlay)
        {
            target = renameOverlay;
        }

        public bool BeginRename_Internals(string name, int userData, float delay) => target.BeginRename(name, userData, delay);
        public void EndRename_Internals(bool acceptChanges) => target.EndRename(acceptChanges);
        public void Clear_Internals() => target.Clear();
        public bool HasKeyboardFocus_Internals() => target.HasKeyboardFocus();
        public bool IsRenaming_Internals() => target.IsRenaming();
        public bool OnEvent_Internals() => target.OnEvent();
        public bool OnGUI_Internals() => target.OnGUI();
        public bool OnGUI_Internals(GUIStyle textFieldStyle) => target.OnGUI(textFieldStyle);
    }
}