using System;
using UnityEditor;

namespace Emilia.Reflection.Editor
{
    public static class EditorApplication_Internals
    {
        public static Action CallDelayed_Internals(EditorApplication.CallbackFunction action, double delaySeconds = 0.0)
        {
            return EditorApplication.CallDelayed(action, delaySeconds);
        }
    }
}