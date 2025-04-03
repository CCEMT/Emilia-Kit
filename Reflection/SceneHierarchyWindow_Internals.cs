using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;

namespace Emilia.Reflection.Editor
{
    public class SceneHierarchyWindow_Internals : SceneHierarchyWindow
    {
        public static Type sceneHierarchyWindowType_Internals => typeof(SceneHierarchyWindow);

        public static EditorWindow lastInteractedHierarchyWindow_Internals => lastInteractedHierarchyWindow;

        public static List<EditorWindow> GetAllSceneHierarchyWindows_Internals() => GetAllSceneHierarchyWindows().OfType<EditorWindow>().ToList();

        public void ReloadData_Internals()
        {
            ReloadData();
        }

        public static void RebuildStageHeaderInAll_Internals()
        {
            RebuildStageHeaderInAll();
        }

        public static void ReloadAllHierarchyWindows_Internals()
        {
            ReloadAllHierarchyWindows();
        }

        public static EditorWindow GetSceneHierarchyWindowToFocusForNewGameObjects_Internals() => GetSceneHierarchyWindowToFocusForNewGameObjects();
    }
}