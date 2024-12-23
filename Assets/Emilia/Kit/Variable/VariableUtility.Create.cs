using System;
using UnityEngine;

namespace Emilia.Variables
{
    public static partial class VariableUtility
    {
        public static Variable Create<T>()
        {
            Type type = typeof(T);
            return Create(type);
        }

        public static Variable Create(Type type)
        {
            if (variableCreate.TryGetValue(type, out var create)) return create();
            Debug.LogError($"{type} 未注册");
            return null;
        }
    }
}