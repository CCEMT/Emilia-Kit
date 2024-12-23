using System;
using UnityEditor.Experimental.GraphView;

namespace Emilia.Reflection.Editor
{
    public class Port_Internals : Port
    {
        public Orientation orientation_Internals
        {
            get => orientation;
            set => orientation = value;
        }

        public Direction direction_Internals
        {
            get => direction;
            set => direction = value;
        }

        public Capacity capacity_Internals
        {
            get => capacity;
            set => capacity = value;
        }

        public Type type_Internals
        {
            get => portType;
            set => portType = value;
        }

        protected Port_Internals(Orientation portOrientation, Direction portDirection, Capacity portCapacity, Type type) : base(portOrientation, portDirection, portCapacity, type) { }
    }
}