using System;
using System.Reflection;
using Emilia.Reflection.Editor;
using MonoHook;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine.UIElements;

namespace Emilia.Kit.Editor
{
    public class GraphView_Hook : GraphView_Internals
    {
        [InitializeOnLoadMethod]
        static void InstallationHook()
        {
            Type graphViewType = typeof(GraphView);
            MethodInfo methodInfo = graphViewType.GetMethod("UpdateContentZoomer", BindingFlags.Instance | BindingFlags.NonPublic);

            Type graphViewHookType = typeof(GraphView_Hook);
            MethodInfo hookInfo = graphViewHookType.GetMethod(nameof(UpdateContentZoomer_Hook), BindingFlags.Instance | BindingFlags.NonPublic);

            MethodHook hook = new MethodHook(methodInfo, hookInfo, null);
            hook.Install();
        }

        private void UpdateContentZoomer_Hook()
        {
            object result = ReflectUtility.Invoke(this, "OnUpdateContentZoomer");
            if (result is true) return;

            if (minScale != maxScale)
            {
                if (zoomer_Internal == null)
                {
                    zoomer_Internal = new ContentZoomer();
                    this.AddManipulator(zoomer_Internal);
                }

                zoomer_Internal.minScale = minScale;
                zoomer_Internal.maxScale = maxScale;
                zoomer_Internal.scaleStep = scaleStep;
                zoomer_Internal.referenceScale = referenceScale;
            }
            else
            {
                if (zoomer_Internal != null) this.RemoveManipulator(zoomer_Internal);
            }

            ValidateTransform();
        }

        protected virtual bool OnUpdateContentZoomer()
        {
            return false;
        }
    }
}