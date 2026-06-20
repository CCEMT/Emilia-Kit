using UnityEditor;
using UnityEditor.IMGUI.Controls;

namespace Emilia.Reflection.Editor
{
    public static class TreeViewStateExtension_Internal
    {
        public static RenameOverlay_Internals GetRenameOverlay_Internal(this TreeViewState state) => new RenameOverlay_Internals(state.renameOverlay);
    }

    public class TreeViewState_Internal : TreeViewState
    {
        public override void OnAwake()
        {
            OnAwake_Internal();
        }

        public virtual void OnAwake_Internal()
        {
            base.OnAwake();
        }
    }

    public class TreeViewStateWithAssetUtility_Internal : TreeViewStateWithAssetUtility
    {
        public CreateAssetUtility_Internal createAssetUtility_Internal
        {
            get => new CreateAssetUtility_Internal(createAssetUtility);
            set => createAssetUtility = value.Target_Internal;
        }
    }
}