using System;
using UnityEngine.UIElements;

namespace Emilia.Reflection.Editor
{
    public static class MeshGenerationContextExtension_Internals
    {
        public static void Painter_DrawImmediate_Internals(this MeshGenerationContext self, Action callback, bool cullingEnabled)
        {
            self.painter.DrawImmediate(callback, cullingEnabled);
        }
    }
}