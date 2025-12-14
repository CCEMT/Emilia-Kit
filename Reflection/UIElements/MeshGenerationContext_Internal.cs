using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace Emilia.Reflection.Editor
{
    public static class MeshGenerationContextExtension_Internal
    {
        public static IStylePainterAgent_Internal GetPainter_Internal(this MeshGenerationContext context) => new IStylePainterAgent_Internal(context.painter);

        public static MeshWriteData Allocate(
            this MeshGenerationContext context,
            int vertexCount,
            int indexCount,
            Texture texture,
            Material material,
            MeshGenerationContext_Internal.MeshFlags_Internals flags) => context.Allocate(vertexCount, indexCount, texture, material, (MeshGenerationContext.MeshFlags) flags);
    }

    public class MeshGenerationContext_Internal : MeshGenerationContext
    {
        public MeshGenerationContext_Internal(IStylePainter painter) : base(painter) { }

        [Flags]
        public enum MeshFlags_Internals
        {
            None = 0,
            UVisDisplacement = 1,
            SkipDynamicAtlas = 2,
        }
    }
}