using Sirenix.OdinInspector;
using Sirenix.OdinInspector.Editor;
using UnityEditor;

namespace Emilia.Kit
{
    public class MenuTestWindow : OdinEditorWindow
    {
        [MenuItem("Window/MenuTest")]
        private static void Open()
        {
            GetWindow<MenuTestWindow>().Show();
        }

        [ValueDropdown("GetIdValue", NumberOfItemsBeforeEnablingSearch = 3)]
        public string id;

        protected ValueDropdownList<string> GetIdValue() =>
            new() {
                {"多么", "option1"},
                {"呀哈喽", "option2"},
                {"哦嗨哟", "option3"},
                {"呵呵", "option4"},
                {"呜呜呜", "option5"},
                {"嘻嘻", "option6"},
                {"怎么说", "option7"},
            };
    }
}