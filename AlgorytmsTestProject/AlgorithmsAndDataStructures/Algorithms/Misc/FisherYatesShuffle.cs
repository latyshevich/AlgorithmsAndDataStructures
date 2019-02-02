using System;
using System.Collections;
using AlgorithmsAndDataStructures.ServicesAndHelpers;

namespace AlgorithmsAndDataStructures.Algorithms.Misc
{
    /// <summary>
    ///     Алгоритм тасования коллекции Фишера-Йетса
    /// </summary>
    public class FisherYatesShuffle
    {
        public void Shuffle(IList list)
        {
            var rnd = new Random(list.Count + (int) DateTime.Now.Ticks);
            for (var curIndex = list.Count - 1; curIndex > 0; curIndex--)
            {
                var ranIndex = rnd.Next(0, curIndex + 1);
                list.Swap(curIndex,ranIndex);
            }
        }
    }

    public static class FisherYatesShuffleExtension
    {
        public static void Shuffle(this IList list)
        {
            new FisherYatesShuffle().Shuffle(list);
        }
    }
}