using UnityEditor;

namespace Emilia.Reflection.Editor
{
    public struct ScriptingMenuItem_Internal
    {
        private ScriptingMenuItem _item;

        internal ScriptingMenuItem Target_Internal => _item;

        public bool isSeparator_Internal => _item.isSeparator;

        public string path_Internal => _item.path;

        public int priority_Internal => _item.priority;

        public ScriptingMenuItem_Internal(ScriptingMenuItem item)
        {
            _item = item;
        }
    }

    public static class Menu_Internals
    {
        public static string[] ExtractSubmenus_Internal(string menuPath) => Menu.ExtractSubmenus(menuPath);

        public static bool GetChecked_Internal(string menuPath) => Menu.GetChecked(menuPath);

        public static bool GetEnabled_Internal(string menuPath) => Menu.GetEnabled(menuPath);

        public static ScriptingMenuItem_Internal[] GetMenuItems_Internal(string menuPath, bool includeSeparators, bool localized)
        {
            ScriptingMenuItem[] items = Menu.GetMenuItems(menuPath, includeSeparators, localized);
            ScriptingMenuItem_Internal[] result = new ScriptingMenuItem_Internal[items.Length];
            for (int i = 0; i < items.Length; i++)
                result[i] = new ScriptingMenuItem_Internal(items[i]);
            return result;
        }
    }
}
