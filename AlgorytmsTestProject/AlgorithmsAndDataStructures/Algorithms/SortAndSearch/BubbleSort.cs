using System;
using AlgorithmsAndDataStructures.Algorithms.Interfaces;
using AlgorithmsAndDataStructures.ServicesAndHelpers;

namespace AlgorithmsAndDataStructures.Algorithms.SortAndSearch
{
    public class BubbleSort : ISortStrategy
    {
        public T[] Sort<T>(T[] array, bool descending = true) where T : IComparable<T>
        {
            var copyArray = new T[array.Length];
            Array.Copy(array, copyArray, array.Length);

            for (var i = 0; i < copyArray.Length - 1; i++)
            for (var j = 0; j < copyArray.Length - 1 - i; j++)
                if (copyArray[j].CompareTo(copyArray[j + 1]) == 1)
                    copyArray.Swap(j, j + 1);
            return copyArray;
        }
    }
}