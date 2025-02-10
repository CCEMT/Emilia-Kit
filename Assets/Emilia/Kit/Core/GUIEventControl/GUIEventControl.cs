using System.Collections.Generic;
using UnityEngine;

namespace Emilia.Kit
{
    public class GUIEventControl
    {
        private readonly List<GUIEventManipulator> _manipulators;

        public GUIEventControl(params GUIEventManipulator[] manipulators)
        {
            this._manipulators = new List<GUIEventManipulator>(manipulators);
        }

        public GUIEventControl(IEnumerable<GUIEventManipulator> manipulators)
        {
            this._manipulators = new List<GUIEventManipulator>(manipulators);
        }

        public bool HandleManipulatorsEvents(object userData)
        {
            bool isHandled = false;

            int count = this._manipulators.Count;

            for (var i = 0; i < count; i++)
            {
                GUIEventManipulator manipulator = this._manipulators[i];
                isHandled = manipulator.HandleEvent(userData);
                if (isHandled) break;
            }

            for (var i = 0; i < count; i++)
            {
                GUIEventManipulator manipulator = this._manipulators[i];
                manipulator.Overlay(Event.current, userData);
            }

            return isHandled;
        }
    }
}