using System.Collections;

namespace AlgorithmsAndDataStructures.ServicesAndHelpers
{
    internal static class SwapElementsCollectionExtension
    {
        public static void Swap(this IList array, int firstIndex, int secondIndex)
        {
            var temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }
    }
}