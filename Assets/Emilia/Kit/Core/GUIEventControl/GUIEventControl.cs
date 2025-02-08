using System.Collections.Generic;

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

            for (var i = 0; i < this._manipulators.Count; i++)
            {
                GUIEventManipulator manipulator = this._manipulators[i];
                isHandled = manipulator.HandleEvent(userData);
                if (isHandled) break;
            }

            return isHandled;
        }
    }
}