using System;
using AlgorithmsAndDataStructures.Algorithms.Interfaces;

namespace AlgorithmsAndDataStructures.Algorithms.SortAndSearch
{
    /// <summary>
    ///     Класс бинарного поиска
    /// </summary>
    public class BinarySearch : ISearchStrategy
    {
        public int? Search<T>(T[] array, T element) where T : IComparable<T>
        {
            var downBound = 0;
            var upperBound = array.Length;
            while (downBound <= upperBound)
            {
                var q = (upperBound + downBound) / 2;
                if (array[q].Equals(element))
                    return q;
                if (array[q].CompareTo(element) == 1)
                    upperBound = --q;
                else
                    downBound = ++q;
            }

            return null;
        }
    }
}