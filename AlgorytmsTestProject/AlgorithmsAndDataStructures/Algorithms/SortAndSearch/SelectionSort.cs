using System;
using AlgorithmsAndDataStructures.ServicesAndHelpers;

namespace AlgorithmsAndDataStructures.Algorithms.SortAndSearch
{
    /// <summary>
    ///     Сортировка выбором
    /// </summary>
    public class SelectionSort
    {
        public T[] Sort<T>(T[] array, bool descending = true) where T : IComparable<T>
        {
            var copyArray = new T[array.Length];
            Array.Copy(array, copyArray, array.Length);
            //для каждого элемента массива, начиная с первого элемента и до предпоследнего включительно
            for (var i = 0; i < copyArray.Length - 1; i++)
            {
                //запоминаем индекс текущего элемента как индекс наибольшего(наименьшего) элемента
                var swapIndex = i;
                //для каждого элемента из подмассива, начиная со следующего элемента от текущего
                //и до конца исходного массива 
                for (var j = i + 1; j < copyArray.Length; j++)
                    //ищим элемент в этом подмассиве который будет меньше (больше) элемента по индексу 
                    swapIndex = descending
                        ? Descending(copyArray, j, swapIndex)
                        : Ascending(copyArray, j, swapIndex);
                //меняем местами текущий элемент и элемент из подмассива который меньше (больше) текущего
                copyArray.Swap(i, swapIndex);
            }

            return copyArray;
        }

        private int Descending<T>(T[] array, int currIndex, int bigestIndex) where T : IComparable<T>
        {
            if (array[currIndex].CompareTo(array[bigestIndex]) == 1)
                return currIndex;
            return bigestIndex;
        }

        private int Ascending<T>(T[] array, int currIndex, int smallestIndex) where T : IComparable<T>
        {
            if (array[currIndex].CompareTo(array[smallestIndex]) == -1)
                return currIndex;
            return smallestIndex;
        }
    }
}