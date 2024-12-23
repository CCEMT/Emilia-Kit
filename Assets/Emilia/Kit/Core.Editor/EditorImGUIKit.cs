using System;
using System.Linq;
using Sirenix.Reflection.Editor;
using Sirenix.Utilities;
using Sirenix.Utilities.Editor;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;
using Object = UnityEngine.Object;

namespace Emilia.Kit.Editor
{
    public static class EditorImGUIKit
    {
        public static EditorWindow GetImGUIWindow()
        {
            IMGUIContainer currentImguiContainer = UIElementsUtility_Internals.GetCurrentIMGUIContainer();

            VisualElement rootVisualContainer = currentImguiContainer;
            while (rootVisualContainer.parent != null)
            {
                rootVisualContainer = rootVisualContainer.parent;
                if (rootVisualContainer.name.Contains("rootVisualContainer")) break;
            }

            EditorWindow[] windows = Resources.FindObjectsOfTypeAll<EditorWindow>();
            for (var i = 0; i < windows.Length; i++)
            {
                EditorWindow window = windows[i];
                if (window.rootVisualElement == rootVisualContainer) return window;
            }

            return null;
        }

        public static EditorWindow CreateWindow(Type type)
        {
            ScriptableObject instance = ScriptableObject.CreateInstance(type);
            EditorWindow window = instance as EditorWindow;
            window.Show();
            return window;
        }

        public static T OpenWindow<T>(string name, int width, int height, bool utility = false) where T : EditorWindow
        {
            if (EditorWindow.HasOpenInstances<T>())
            {
                T window = EditorWindow.GetWindow<T>(utility, name);
                window.Focus();
                return window;
            }
            else
            {
                T window = EditorWindow.GetWindow<T>(utility, name);
                window.position = GUIHelper.GetEditorWindowRect().AlignCenter(width, height);
                return window;
            }
        }

        public static T AddToWindow<T>(string name, params Type[] windowTypes) where T : EditorWindow
        {
            T window = null;
            if (EditorWindow.HasOpenInstances<T>() == false)
            {
                window = EditorWindow.CreateWindow<T>(name, windowTypes);
            }
            else
            {
                window = EditorWindow.GetWindow<T>(name);
                window.Focus();
            }
            return window;
        }

        public static void CloseWindow<T>() where T : EditorWindow
        {
            T[] windows = Resources.FindObjectsOfTypeAll<T>();
            int amount = windows.Length;
            for (int i = 0; i < amount; i++)
            {
                T window = windows[i];
                window.Close();
            }
        }
        
        public static EditorWindow FindEditorWindowOfType(Type type)
        {
            Object[] results = Resources.FindObjectsOfTypeAll(type);
            return results.FirstOrDefault() as EditorWindow;
        }
    }
}