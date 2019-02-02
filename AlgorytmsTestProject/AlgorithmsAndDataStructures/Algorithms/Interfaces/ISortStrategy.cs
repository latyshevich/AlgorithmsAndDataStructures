using System;

namespace AlgorithmsAndDataStructures.Algorithms.Interfaces
{
    /// <summary>
    ///     Интерфейс стратегии сортировки элементов в массиве
    /// </summary>
    internal interface ISortStrategy
    {
        /// <summary>
        ///     Метод сортировки массива
        /// </summary>
        /// <typeparam name="T">Параметр тип элементов в массиве</typeparam>
        /// <param name="array">Входной не отсортированный массив</param>
        /// <param name="descending">Направление сортировки</param>
        /// <returns>Отсортированный массив</returns>
        T[] Sort<T>(T[] array, bool descending = true) where T : IComparable<T>;
    }
}