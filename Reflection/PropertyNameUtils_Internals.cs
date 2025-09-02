using UnityEngine;
using UnityEngine.Bindings;

namespace Emilia.Reflection.Editor
{
    public static class PropertyNameUtils_Internals
    {
        [FreeFunction(IsThreadSafe = true)]
        public static PropertyName PropertyNameFromString_Internals([Unmarshalled] string name) => PropertyNameUtils.PropertyNameFromString(name);

        [FreeFunction(IsThreadSafe = true)]
        public static string StringFromPropertyName_Internals(PropertyName propertyName) => PropertyNameUtils.StringFromPropertyName(propertyName);

        [FreeFunction(IsThreadSafe = true)]
        public static int ConflictCountForID_Internals(int id) => PropertyNameUtils.ConflictCountForID(id);
    }
}