using System;
using UnityEngine;
using UnityEngine.UIElements;

namespace Emilia.Reflection.Editor
{
    public struct IStylePainterAgent_Internal
    {
        private IStylePainter stylePainter;

        public IStylePainterAgent_Internal(IStylePainter stylePainter)
        {
            this.stylePainter = stylePainter;
        }

        public VisualElement visualElement => this.stylePainter.visualElement;

        public MeshWriteData DrawMesh_Internal(
            int vertexCount,
            int indexCount,
            Texture texture,
            Material material,
            MeshGenerationContext_Internal.MeshFlags_Internals flags)
            => this.stylePainter.DrawMesh(vertexCount, indexCount, texture, material, (MeshGenerationContext.MeshFlags) flags);

        public void DrawText(
            MeshGenerationContextUtils.TextParams textParams,
            ITextHandle handle,
            float pixelsPerPoint)
            => this.stylePainter.DrawText(textParams, handle, pixelsPerPoint);

        public void DrawRectangle(MeshGenerationContextUtils.RectangleParams rectParams) => this.stylePainter.DrawRectangle(rectParams);

        public void DrawBorder(MeshGenerationContextUtils.BorderParams borderParams) => this.stylePainter.DrawBorder(borderParams);

        public void DrawImmediate(Action callback, bool cullingEnabled) => this.stylePainter.DrawImmediate(callback, cullingEnabled);
    }
}