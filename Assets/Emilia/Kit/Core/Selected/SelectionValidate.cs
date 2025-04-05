using System;
using System.Collections.Generic;
using Sirenix.Utilities;
using UnityEditor;
using Object = UnityEngine.Object;

namespace Emilia.Kit
{
    public class SelectionValidateObjectAttribute : Attribute { }

    public static class SelectionValidate
    {
        private static Dictionary<Object, Func<bool>> validates = new Dictionary<Object, Func<bool>>();

        public static void Registration(Object selectedObject, Func<bool> validate)
        {
            if (selectedObject == null) return;
            validates[selectedObject] = validate;
        }

        public static void UnRegistration(Object selectedObject)
        {
            if (selectedObject == null) return;
            if (validates.ContainsKey(selectedObject)) validates.Remove(selectedObject);
        }

        public static void UpdateSelected()
        {
            List<Object> selectedObjects = new List<Object>(Selection.objects);
            for (int i = selectedObjects.Count - 1; i >= 0; i--)
            {
                Object selectedObject = selectedObjects[i];
                if (selectedObject == null) continue;

                if (validates.TryGetValue(selectedObject, out Func<bool> validate))
                {
                    bool result = validate?.Invoke() ?? false;
                    if (result) continue;

                    validates.Remove(selectedObject);
                    selectedObjects.RemoveAt(i);
                }
                else
                {
                    SelectionValidateObjectAttribute attribute = selectedObject.GetType().GetAttribute<SelectionValidateObjectAttribute>(true);
                    if (attribute != null) selectedObjects.RemoveAt(i);
                }
            }
        }
    }
}