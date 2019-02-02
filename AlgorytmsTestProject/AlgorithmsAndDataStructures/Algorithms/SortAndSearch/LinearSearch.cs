using System;

namespace AlgorithmsAndDataStructures.Algorithms.SortAndSearch
{
    /// <summary>
    ///     Класс линейного поиска
    /// </summary>
    public class LinearSearch
    {
        public static int SearchElement<T>(T element, T[] array) where T : IEquatable<T>
        {
            for (var index = 0; index < array.Length; index++)
                if (array[index].Equals(element))
                    return index;
            return -1;
        }
    }
}