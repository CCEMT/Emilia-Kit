#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using System.Linq;
using Emilia.Kit.Editor;
using Sirenix.OdinInspector.Editor;
using Sirenix.Utilities;
using UnityEditor;
using UnityEngine;
using Action = System.Action;
using Object = UnityEngine.Object;

namespace Emilia.Kit
{
    public class OdinMenu
    {
        private struct MenuItem
        {
            public object userData;
            public Action<object> action;
        }

        private Dictionary<string, MenuItem> items = new Dictionary<string, MenuItem>();

        public string title { get; set; }

        public float defaultWidth { get; set; } = 200f;

        public bool isEnablePinYinSearch { get; set; } = true;

        public OdinMenu(string name = "选择")
        {
            title = name;
        }

        public bool HasItem(string name) => items.ContainsKey(name);

        public void AddItem(string name, Action action)
        {
            MenuItem menuItem = new MenuItem();
            menuItem.action = (_) => action?.Invoke();
            items[name] = menuItem;
        }

        public void AddItem(string name, object userData, Action<object> action)
        {
            MenuItem menuItem = new MenuItem();
            menuItem.userData = userData;
            menuItem.action = action;
            items[name] = menuItem;
        }

        public OdinEditorWindow ShowInPopup() => ShowInPopup(defaultWidth);

        public OdinEditorWindow ShowInPopup(float width)
        {
            GenericSelector<Action> customGenericSelector = GetSelector();
            return customGenericSelector.ShowInPopup(width);
        }

        public OdinEditorWindow ShowInPopup(Rect rect, float width)
        {
            GenericSelector<Action> customGenericSelector = GetSelector();
            return customGenericSelector.ShowInPopup(rect, width);
        }

        private GenericSelector<Action> GetSelector()
        {
            IEnumerable<GenericSelectorItem<Action>> customCollection = items.Keys.Select(itemName =>
                new GenericSelectorItem<Action>($"{itemName}", () => items[itemName].action(items[itemName].userData)));

            GenericSelector<Action> customGenericSelector = new(title, false, customCollection);

            if (isEnablePinYinSearch)
            {
                customGenericSelector.SelectionTree.Config.SearchFunction = item => {
                    string target = item.SearchString;
                    string input = customGenericSelector.SelectionTree.Config.SearchTerm;
                    return SearchUtility.Search(target, input);
                };
            }

            customGenericSelector.EnableSingleClickToSelect();

            customGenericSelector.SelectionChanged += ints => {
                Action result = ints.FirstOrDefault();
                if (result != null) result();
            };

            return customGenericSelector;
        }

        public void Clear()
        {
            items.Clear();
        }

        public static void ShowInPopupObject<T>(Action<T> onSelected)
        {
            ShowInPopupObject<T>("选择", onSelected);
        }

        public static void ShowInPopupObject<T>(string title, Action<T> onSelected)
        {
            ShowInPopupObject<T>(title, 200f, onSelected);
        }

        public static void ShowInPopupObject<T>(string title, float width, Action<T> onSelected)
        {
            ShowInPopupType<T>(title, width, (type) => { onSelected?.Invoke((T) ReflectUtility.CreateInstance(type)); });
        }

        public static void ShowInPopupType<T>(Action<Type> onSelected)
        {
            ShowInPopupType<T>("选择", onSelected);
        }

        public static void ShowInPopupType<T>(string title, Action<Type> onSelected)
        {
            ShowInPopupType<T>(title, 200f, onSelected);
        }

        public static void ShowInPopupType<T>(string title, float width, Action<Type> onSelected)
        {
            OdinMenu menu = new(title);

            IList<Type> types = TypeCache.GetTypesDerivedFrom<T>();
            for (int i = 0; i < types.Count; i++)
            {
                Type type = types[i];
                if (type.IsAbstract || type.IsInterface) continue;

                string displayName = type.Name;
                TextAttribute textAttribute = type.GetCustomAttribute<TextAttribute>(true);
                if (textAttribute != null) displayName = textAttribute.text;

                menu.AddItem(displayName, () => onSelected(type));
            }

            menu.ShowInPopup(width);
        }

        public static void ShowInPopupScriptableObject<T>(Action<T> onSelected) where T : ScriptableObject
        {
            ShowInPopupScriptableObject<T>("选择", onSelected);
        }

        public static void ShowInPopupScriptableObject<T>(string title, Action<T> onSelected) where T : ScriptableObject
        {
            ShowInPopupScriptableObject<T>(title, 200f, onSelected);
        }

        public static void ShowInPopupScriptableObject<T>(string title, float width, Action<T> onSelected) where T : ScriptableObject
        {
            OdinMenu menu = new(title);

            T[] resources = EditorAssetKit.GetEditorResources<T>();
            for (int i = 0; i < resources.Length; i++)
            {
                T asset = resources[i];
                if (asset == null) continue;

                string displayName = asset.name;
                string description = ObjectDescriptionUtility.GetDescription(asset);
                if (string.IsNullOrEmpty(description) == false) displayName += $"({description})";

                menu.AddItem(displayName, () => onSelected(asset));
            }

            menu.ShowInPopup(width);
        }

        public static void ShowInPopupScriptableObjectPath<T>(string path, Action<T> onSelected) where T : ScriptableObject
        {
            ShowInPopupScriptableObjectPath(path, "选择", onSelected);
        }

        public static void ShowInPopupScriptableObjectPath<T>(string path, string title, Action<T> onSelected) where T : ScriptableObject
        {
            ShowInPopupScriptableObjectPath(path, title, 200f, onSelected);
        }

        public static void ShowInPopupScriptableObjectPath<T>(string path, string title, float width, Action<T> onSelected) where T : ScriptableObject
        {
            OdinMenu menu = new(title);

            List<T> resources = EditorAssetKit.LoadAssetAtPath<T>(path);
            for (int i = 0; i < resources.Count; i++)
            {
                T asset = resources[i];
                if (asset == null) continue;

                string displayName = asset.name;
                string description = ObjectDescriptionUtility.GetDescription(asset);
                if (string.IsNullOrEmpty(description) == false) displayName += $"({description})";

                menu.AddItem(displayName, () => onSelected(asset));
            }

            menu.ShowInPopup(width);
        }

        public static void ShowInPopupPrefab(string path, Action<GameObject> onSelected)
        {
            ShowInPopupPrefab(path, "选择", onSelected);
        }

        public static void ShowInPopupPrefab(string path, string title, Action<GameObject> onSelected)
        {
            ShowInPopupPrefab(path, title, 200f, onSelected);
        }

        public static void ShowInPopupPrefab(string path, string title, float width, Action<GameObject> onSelected)
        {
            OdinMenu menu = new(title);

            List<GameObject> resources = EditorAssetKit.LoadAtPath<GameObject>(path, "*.prefab");
            for (int i = 0; i < resources.Count; i++)
            {
                GameObject prefab = resources[i];
                if (prefab == null) continue;

                string displayName = prefab.name;
                IObjectDescription descriptionComponent = prefab.GetComponent<IObjectDescription>();
                if (descriptionComponent != null) displayName += $"({descriptionComponent.description})";

                menu.AddItem(displayName, () => onSelected(prefab));
            }

            menu.ShowInPopup(width);
        }

        public static void ShowInPopupAsset<T>(string path, string searchPattern, Action<T> onSelected) where T : Object
        {
            ShowInPopupAsset(path, searchPattern, "选择", onSelected);
        }

        public static void ShowInPopupAsset<T>(string path, string searchPattern, string title, Action<T> onSelected) where T : Object
        {
            ShowInPopupAsset(path, searchPattern, title, 200f, onSelected);
        }

        public static void ShowInPopupAsset<T>(string path, string searchPattern, string title, float width, Action<T> onSelected) where T : Object
        {
            OdinMenu menu = new(title);

            List<T> resources = EditorAssetKit.LoadAtPath<T>(path, searchPattern);
            for (int i = 0; i < resources.Count; i++)
            {
                T asset = resources[i];
                if (asset == null) continue;

                string displayName = asset.name;
                string description = ObjectDescriptionUtility.GetDescription(asset);
                if (string.IsNullOrEmpty(description) == false) displayName += $"({description})";

                menu.AddItem(displayName, () => onSelected(asset));
            }

            menu.ShowInPopup(width);
        }
    }
}
#endif