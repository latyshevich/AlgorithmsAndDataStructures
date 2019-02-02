using System;

namespace AlgorithmsAndDataStructures.Algorithms.Interfaces
{
    /// <summary>
    ///     Интерфейс стратегии поиска эелемента в массиве
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal interface ISearchStrategy
    {
        int? Search<T>(T[] array, T element) where T : IComparable<T>;
    }
}