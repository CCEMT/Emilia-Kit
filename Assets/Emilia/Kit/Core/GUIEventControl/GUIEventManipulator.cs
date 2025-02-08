using Emilia.Reflection.Editor;
using UnityEngine;

namespace Emilia.Kit
{
    public abstract class GUIEventManipulator
    {
        private int id;

        public bool HandleEvent(object userData)
        {
            Event currentEvent = Event.current;
            EventType type = currentEvent.GetTypeForControl(id);
            return HandleEvent(type, currentEvent, userData);
        }

        public bool HandleEvent(EventType type, object userData)
        {
            Event currentEvent = Event.current;
            return HandleEvent(type, currentEvent, userData);
        }

        private bool HandleEvent(EventType type, Event evt, object userData)
        {
            if (id == 0) id = GUIUtility_Internals.GetPermanentControlID_Internals();

            bool isHandled = false;
            switch (type)
            {
                case EventType.ScrollWheel:
                    isHandled = MouseWheel(evt, userData);
                    break;

                case EventType.MouseUp:
                {
                    if (GUIUtility.hotControl == id)
                    {
                        isHandled = MouseUp(evt, userData);

                        GUIUtility.hotControl = 0;
                        evt.Use();
                    }
                    break;
                }
                
                case EventType.MouseDown:
                {
                    isHandled = evt.clickCount < 2 ? MouseDown(evt, userData) : DoubleClick(evt, userData);

                    if (isHandled) GUIUtility.hotControl = id;
                    break;
                }
                
                case EventType.MouseDrag:
                {
                    if (GUIUtility.hotControl == id) isHandled = MouseDrag(evt, userData);
                    break;
                }
                
                case EventType.KeyDown:
                    isHandled = KeyDown(evt, userData);
                    break;

                case EventType.KeyUp:
                    isHandled = KeyUp(evt, userData);
                    break;

                case EventType.ContextClick:
                    isHandled = ContextClick(evt, userData);
                    break;

                case EventType.ValidateCommand:
                    isHandled = ValidateCommand(evt, userData);
                    break;

                case EventType.ExecuteCommand:
                    isHandled = ExecuteCommand(evt, userData);
                    break;
            }

            if (isHandled) evt.Use();

            return isHandled;
        }

        protected virtual bool MouseDown(Event evt, object userData)
        {
            return false;
        }

        protected virtual bool MouseDrag(Event evt, object userData)
        {
            return false;
        }

        protected virtual bool MouseWheel(Event evt, object userData)
        {
            return false;
        }

        protected virtual bool MouseUp(Event evt, object userData)
        {
            return false;
        }

        protected virtual bool DoubleClick(Event evt, object userData)
        {
            return false;
        }

        protected virtual bool KeyDown(Event evt, object userData)
        {
            return false;
        }

        protected virtual bool KeyUp(Event evt, object userData)
        {
            return false;
        }

        protected virtual bool ContextClick(Event evt, object userData)
        {
            return false;
        }

        protected virtual bool ValidateCommand(Event evt, object userData)
        {
            return false;
        }

        protected virtual bool ExecuteCommand(Event evt, object userData)
        {
            return false;
        }

        public virtual void Overlay(Event evt, object userData) { }
    }
}