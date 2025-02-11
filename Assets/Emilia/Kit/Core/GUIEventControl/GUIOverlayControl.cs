using System.Collections.Generic;
using UnityEngine;

namespace Emilia.Kit
{
    public class GUIOverlayControl
    {
        private List<GUIEventManipulator> _manipulators = new List<GUIEventManipulator>();

        private void AddManipulator(GUIEventManipulator manipulator)
        {
            this._manipulators.Add(manipulator);
        }

        public void RemoveManipulator(GUIEventManipulator manipulator)
        {
            this._manipulators.Remove(manipulator);
        }

        public void Overlay(object userData)
        {
            int count = this._manipulators.Count;
            for (var i = 0; i < count; i++)
            {
                GUIEventManipulator manipulator = this._manipulators[i];
                manipulator.Overlay(Event.current, this, userData);
            }
        }

        public void Clear()
        {
            this._manipulators.Clear();
        }
    }
}