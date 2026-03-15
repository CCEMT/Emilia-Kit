using UnityEditor;
using UnityEditor.ProjectWindowCallback;
using UnityEngine;

namespace Emilia.Reflection.Editor
{
    public struct CreateAssetUtility_Internal
    {
        private CreateAssetUtility _createAssetUtility;

        internal CreateAssetUtility Target_Internal => _createAssetUtility;

        public int instanceID_Internal => _createAssetUtility.instanceID;
        public Texture2D icon_Internal => _createAssetUtility.icon;
        public string folder_Internal => _createAssetUtility.folder;
        public string extension_Internal => _createAssetUtility.extension;
        public string originalName_Internal => _createAssetUtility.originalName;
        public EndNameEditAction endAction_Internal => _createAssetUtility.endAction;
        public string m_Path_Internal
        {
            get => _createAssetUtility.m_Path;
            set => _createAssetUtility.m_Path = value;
        }

        public string m_ResourceFile_Internal
        {
            get => _createAssetUtility.m_ResourceFile;
            set => _createAssetUtility.m_ResourceFile = value;
        }

        public CreateAssetUtility_Internal(CreateAssetUtility createAssetUtility)
        {
            _createAssetUtility = createAssetUtility;
        }

        public bool BeginNewAssetCreation_Internal(
            int instanceID,
            EndNameEditAction newAssetEndAction,
            string filePath,
            Texture2D icon,
            string newAssetResourceFile) => _createAssetUtility.BeginNewAssetCreation(instanceID, newAssetEndAction, filePath, icon, newAssetResourceFile);

        public void EndNewAssetCreation_Internal(string name)
        {
            _createAssetUtility.EndNewAssetCreation(name);
        }

        public void EndNewAssetCreationCanceled_Internal(string name)
        {
            _createAssetUtility.EndNewAssetCreationCanceled(name);
        }

        public void Clear_Internal()
        {
            _createAssetUtility.Clear();
        }

        public bool IsCreatingNewAsset_Internal() => _createAssetUtility.IsCreatingNewAsset();

        public static bool IsPathDataValid(string filePath) => CreateAssetUtility.IsPathDataValid(filePath);
    }
}
