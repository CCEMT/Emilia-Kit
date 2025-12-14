using Unity.Collections;
using UnityEngine;
using UnityEngine.UIElements;

namespace Emilia.Reflection.Editor
{
    public static class MeshWriteData_Internal
    {
        public static NativeSlice<Vertex> GetVertices_Internal(this MeshWriteData self) => self.m_Vertices;
        public static void SetVertices_Internal(this MeshWriteData self, NativeSlice<Vertex> vertices) => self.m_Vertices = vertices;

        public static NativeSlice<ushort> GetIndices_Internal(this MeshWriteData self) => self.m_Indices;
        public static void SetIndices_Internal(this MeshWriteData self, NativeSlice<ushort> indices) => self.m_Indices = indices;

        public static Rect GetUVRegion_Internal(this MeshWriteData self) => self.m_UVRegion;
        public static void SetUVRegion_Internal(this MeshWriteData self, Rect uvRegion) => self.m_UVRegion = uvRegion;

        public static int GetCurrentIndex_Internal(this MeshWriteData self) => self.currentIndex;
        public static void SetCurrentIndex_Internal(this MeshWriteData self, int currentIndex) => self.currentIndex = currentIndex;

        public static int GetCurrentVertex_Internal(this MeshWriteData self) => self.currentVertex;
        public static void SetCurrentVertex_Internal(this MeshWriteData self, int currentVertex) => self.currentVertex = currentVertex;

        public static void Reset(this MeshWriteData self, NativeSlice<Vertex> vertices, NativeSlice<ushort> indices) => self.Reset(vertices, indices);
        public static void Reset(this MeshWriteData self, NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, Rect uvRegion) => self.Reset(vertices, indices, uvRegion);
    }
}