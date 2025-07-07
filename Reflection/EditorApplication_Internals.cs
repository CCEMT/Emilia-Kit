using System;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine.Events;

namespace Emilia.Reflection.Editor
{
    public static class EditorApplication_Internals
    {
        private static Dictionary<Action, UnityAction> projectWasLoadedActionMap = new Dictionary<Action, UnityAction>();

        public static event Action projectWasLoaded_Internals
        {
            add
            {
                if (projectWasLoadedActionMap.ContainsKey(value)) return;

                UnityAction action = () => value();
                projectWasLoadedActionMap[value] = action;
                EditorApplication.projectWasLoaded += action;

            }
            remove
            {
                if (projectWasLoadedActionMap.TryGetValue(value, out UnityAction action) == false) return;
                EditorApplication.projectWasLoaded -= action;
                projectWasLoadedActionMap.Remove(value);
            }
        }

        private static Dictionary<Action, UnityAction> editorApplicationQuitActionMap = new Dictionary<Action, UnityAction>();

        public static event Action editorApplicationQuit_Internals
        {
            add
            {
                if (editorApplicationQuitActionMap.ContainsKey(value)) return;

                UnityAction action = () => value();
                editorApplicationQuitActionMap[value] = action;
                EditorApplication.editorApplicationQuit += action;
            }
            remove
            {
                if (editorApplicationQuitActionMap.TryGetValue(value, out UnityAction action) == false) return;
                EditorApplication.editorApplicationQuit -= action;
                editorApplicationQuitActionMap.Remove(value);
            }
        }

        private static Dictionary<Action, EditorApplication.CallbackFunction> refreshHierarchyActionMap = new Dictionary<Action, EditorApplication.CallbackFunction>();

        public static event Action refreshHierarchy_Internals
        {
            add
            {
                if (refreshHierarchyActionMap.ContainsKey(value)) return;

                EditorApplication.CallbackFunction action = () => value();
                refreshHierarchyActionMap[value] = action;
                EditorApplication.refreshHierarchy += action;
            }
            remove
            {
                if (refreshHierarchyActionMap.TryGetValue(value, out EditorApplication.CallbackFunction action) == false) return;
                EditorApplication.refreshHierarchy -= action;
                refreshHierarchyActionMap.Remove(value);
            }
        }

        private static Dictionary<Action, EditorApplication.CallbackFunction> dirtyHierarchySortingActionMap = new Dictionary<Action, EditorApplication.CallbackFunction>();

        public static event Action dirtyHierarchySorting_Internals
        {
            add
            {
                if (dirtyHierarchySortingActionMap.ContainsKey(value)) return;

                EditorApplication.CallbackFunction action = () => value();
                dirtyHierarchySortingActionMap[value] = action;
                EditorApplication.dirtyHierarchySorting += action;
            }
            remove
            {
                if (dirtyHierarchySortingActionMap.TryGetValue(value, out EditorApplication.CallbackFunction action) == false) return;
                EditorApplication.dirtyHierarchySorting -= action;
                dirtyHierarchySortingActionMap.Remove(value);
            }
        }

        private static Dictionary<Action, EditorApplication.CallbackFunction> assetLabelsChangedActionMap = new Dictionary<Action, EditorApplication.CallbackFunction>();

        public static event Action assetLabelsChanged_Internals
        {
            add
            {
                if (assetLabelsChangedActionMap.ContainsKey(value)) return;

                EditorApplication.CallbackFunction action = () => value();
                assetLabelsChangedActionMap[value] = action;
                EditorApplication.assetLabelsChanged += action;
            }
            remove
            {
                if (assetLabelsChangedActionMap.TryGetValue(value, out EditorApplication.CallbackFunction action) == false) return;
                EditorApplication.assetLabelsChanged -= action;
                assetLabelsChangedActionMap.Remove(value);
            }
        }

        private static Dictionary<Action, EditorApplication.CallbackFunction> assetBundleNameChangedActionMap = new Dictionary<Action, EditorApplication.CallbackFunction>();

        public static event Action assetBundleNameChanged_Internals
        {
            add
            {
                if (assetBundleNameChangedActionMap.ContainsKey(value)) return;

                EditorApplication.CallbackFunction action = () => value();
                assetBundleNameChangedActionMap[value] = action;
                EditorApplication.assetBundleNameChanged += action;
            }
            remove
            {
                if (assetBundleNameChangedActionMap.TryGetValue(value, out EditorApplication.CallbackFunction action) == false) return;
                EditorApplication.assetBundleNameChanged -= action;
                assetBundleNameChangedActionMap.Remove(value);
            }
        }

        private static Dictionary<Action, EditorApplication.CallbackFunction> fileMenuSavedActionMap = new Dictionary<Action, EditorApplication.CallbackFunction>();

        public static event Action fileMenuSaved_Internals
        {
            add
            {
                if (fileMenuSavedActionMap.ContainsKey(value)) return;

                EditorApplication.CallbackFunction action = () => value();
                fileMenuSavedActionMap[value] = action;
                EditorApplication.fileMenuSaved += action;
            }
            remove
            {
                if (fileMenuSavedActionMap.TryGetValue(value, out EditorApplication.CallbackFunction action) == false) return;
                EditorApplication.fileMenuSaved -= action;
                fileMenuSavedActionMap.Remove(value);
            }
        }

        private static Dictionary<Action, EditorApplication.CallbackFunction> globalEventHandlerActionMap = new Dictionary<Action, EditorApplication.CallbackFunction>();

        public static event Action globalEventHandler_Internals
        {
            add
            {
                if (globalEventHandlerActionMap.ContainsKey(value)) return;

                EditorApplication.CallbackFunction action = () => value();
                globalEventHandlerActionMap[value] = action;
                EditorApplication.globalEventHandler += action;
            }
            remove
            {
                if (globalEventHandlerActionMap.TryGetValue(value, out EditorApplication.CallbackFunction action) == false) return;
                EditorApplication.globalEventHandler -= action;
                globalEventHandlerActionMap.Remove(value);
            }
        }

        public static event Func<bool> doPressedKeysTriggerAnyShortcut_Internals
        {
            add => EditorApplication.doPressedKeysTriggerAnyShortcut += value;
            remove => EditorApplication.doPressedKeysTriggerAnyShortcut -= value;
        }

        private static Dictionary<Action, EditorApplication.CallbackFunction> windowsReorderedActionMap = new Dictionary<Action, EditorApplication.CallbackFunction>();

        public static event Action windowsReordered_Internals
        {
            add
            {
                if (windowsReorderedActionMap.ContainsKey(value)) return;

                EditorApplication.CallbackFunction action = () => value();
                windowsReorderedActionMap[value] = action;
                EditorApplication.windowsReordered += action;
            }
            remove
            {
                if (windowsReorderedActionMap.TryGetValue(value, out EditorApplication.CallbackFunction action) == false) return;
                EditorApplication.windowsReordered -= action;
                windowsReorderedActionMap.Remove(value);
            }
        }

        public static Action CallDelayed_Internals(EditorApplication.CallbackFunction action, double delaySeconds = 0.0) => EditorApplication.CallDelayed(action, delaySeconds);
    }
}