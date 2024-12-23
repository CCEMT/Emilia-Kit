#if UNITY_EDITOR
using System;
using System.Collections.Generic;
using System.Linq;
using Sirenix.OdinInspector.Editor;
using UnityEngine;
using Action = System.Action;

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

        public OdinMenu(string name = "选择")
        {
            title = name;
        }

        public bool HasItem(string name)
        {
            return items.ContainsKey(name);
        }

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

        public OdinEditorWindow ShowInPopup()
        {
            return ShowInPopup(defaultWidth);
        }

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

        GenericSelector<Action> GetSelector()
        {
            IEnumerable<GenericSelectorItem<Action>> customCollection = items.Keys.Select(itemName =>
                new GenericSelectorItem<Action>($"{itemName}", () => items[itemName].action(items[itemName].userData)));

            GenericSelector<Action> customGenericSelector = new(title, false, customCollection);
            customGenericSelector.EnableSingleClickToSelect();

            customGenericSelector.SelectionChanged += ints => {
                Action result = ints.FirstOrDefault();
                if (result != null) result();
            };

            return customGenericSelector;
        }
    }
}
#endif