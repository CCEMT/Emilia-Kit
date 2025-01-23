using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;

namespace Emilia.Reflection.Editor
{
    public static class PlacematExtension_Internals
    {
        public static void GetElementsToMove_Internals(this Placemat self, bool moveOnlyPlacemat, HashSet<GraphElement> collectedElementsToMove)
        {
            self.GetElementsToMove(moveOnlyPlacemat, collectedElementsToMove);
        }
    }
}