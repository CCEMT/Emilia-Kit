using System;

namespace Emilia.Kit
{
    [Serializable]
    public abstract class LocalSetting<T> where T : LocalSetting<T>, new()
    {
        private const string SettingKey = "##Emilia.Kit.LocalSetting";

        private static T _instance;

        public static T instance
        {
            get
            {
                if (_instance != null) return _instance;

                string key = $"{SettingKey}.{typeof(T).FullName}";

                if (OdinEditorPrefs.HasValue(key)) _instance = OdinEditorPrefs.GetValue<T>(key);
                else
                {
                    _instance = new T();
                    OdinEditorPrefs.SetValue(key, _instance);
                }

                return _instance;
            }
        }
    }
}