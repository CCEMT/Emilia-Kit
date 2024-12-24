using System;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;

namespace Emilia.Reflection.Editor
{
    public class InspectorWindow_Internals : InspectorWindow
    {
        public static Type inspectorWindowType_Internals => typeof(InspectorWindow);

        public static void RepaintAllInspectors_Internals()
        {
            RepaintAllInspectors();
        }

        public static void RefreshInspectors_Internals()
        {
            RefreshInspectors();
        }

        public static List<EditorWindow> GetInspectors_Internals()
        {
            return GetInspectors().OfType<EditorWindow>().ToList();
        }

        public static void ApplyChanges_Internals()
        {
            ApplyChanges();
        }

        public static void AddInspectorWindow_Internals(InspectorWindow window)
        {
            AddInspectorWindow(window);
        }

        public static void RemoveInspectorWindow_Internals(InspectorWindow window)
        {
            RemoveInspectorWindow(window);
        }

        public static void ShowWindow_Internals()
        {
            ShowWindow();
        }
    }
}