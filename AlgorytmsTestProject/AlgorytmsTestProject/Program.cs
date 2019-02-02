using System;
using System.Diagnostics;
using AlgorithmsAndDataStructures.Algorithms.Misc;
using AlgorithmsAndDataStructures.Algorithms.SortAndSearch;

namespace AlgorytmsTestProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var randomArray = GetRandomArray(10000, 0, 50);

            randomArray.Shuffle();

            //randomArray.Shuffle();
            //PrintArray<int>(randomArray);
            //Console.ReadLine();

            SortProfilingTest(randomArray);
            
            Console.ReadLine();
        }

        private static void SortProfilingTest(int[] randomArray)
        {
            var quicksort = new QuickSort();
            var insertionSort = new InsertionSort();
            var selecSort = new SelectionSort();
            var gnomeSort = new GnomeSort();
            var bubbleSort = new BubbleSort();
            var cocktailSort = new CocktailSort();
            var mergeSort = new MergeSort();

            var actionQuick = new Func<object>(() =>
            {
                var sortedArray = quicksort.Sort(randomArray);
                return sortedArray;
            });

            var actionMerge = new Func<object>(() =>
            {
                var sortedArray = mergeSort.Sort(randomArray);
                return sortedArray;
            });

            var actionSelect = new Func<object>(() =>
            {
                var sortedArray = selecSort.Sort(randomArray);
                return sortedArray;
            });

            var actionInsert = new Func<object>(() =>
            {
                var sortedArray = insertionSort.Sort(randomArray);
                return sortedArray;
            });

            var actionBubble = new Func<object>(() =>
            {
                var sortedArray = bubbleSort.Sort(randomArray);
                return sortedArray;
            });

            var actionGnome = new Func<object>(() =>
            {
                var sortedArray = gnomeSort.Sort(randomArray);
                return sortedArray;
            });

            var actionCocktail = new Func<object>(() =>
            {
                var sortedArray = cocktailSort.Sort(randomArray);
                return sortedArray;
            });

            var result1 = Profiler(actionQuick);
            Console.WriteLine($"Elapsed time for Quick sort: {result1.Item2}");
            //Console.ReadLine();
            //PrintArray<int>((int[])result2.Item1);

            var result2 = Profiler(actionMerge);
            Console.WriteLine($"Elapsed time for Merge sort: {result2.Item2}");
            //Console.ReadLine();
            //PrintArray<int>((int[])result.Item1);

            var result3 = Profiler(actionSelect);
            Console.WriteLine($"Elapsed time for Selection sort: {result3.Item2}");
            //Console.ReadLine();
            //PrintArray<int>((int[])result3.Item1);

            var result4 = Profiler(actionInsert);
            Console.WriteLine($"Elapsed time for Insertion sort: {result4.Item2}");
            //Console.ReadLine();

            var result5 = Profiler(actionBubble);
            Console.WriteLine($"Elapsed time for Bubble sort: {result5.Item2}");
            //Console.ReadLine();

            var result6 = Profiler(actionGnome);
            Console.WriteLine($"Elapsed time for Gnome sort: {result6.Item2}");
            //Console.ReadLine();

            var result7 = Profiler(actionCocktail);
            Console.WriteLine($"Elapsed time for Cocktail sort: {result7.Item2}");
            //Console.ReadLine();
        }

        private static void PrintArray<T>(T[] array)
        {
            var count = 1;
            for (var i = 0; i < array.Length; i++)
                if (count <= 10)
                {
                    Console.Write($"{array[i]}; ");
                    count++;
                }
                else
                {
                    count = 1;
                    Console.WriteLine();
                }
        }

        private static int[] GetRandomArray(int count, int downBound, int upperBound)
        {
            if (downBound >= upperBound)
                throw new ArgumentException("upperbound < downbound");
            var array = new int[count];
            var rnd = new Random();
            for (var i = 0; i < array.Length; i++) array[i] = rnd.Next(downBound, upperBound + 1);
            return array;
        }

        private static int[] GetIncrimentArray(int count)
        {
            var array = new int[count];
            for (var i = 0; i < count; i++) array[i] = i;

            return array;
        }

        private static void SearchTest()
        {
            int[] array = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            var index = new BinarySearch().Search(array, 8);
            Console.WriteLine(index);
        }

        private static Tuple<object, TimeSpan> Profiler(Func<object> action)
        {
            var watch = new Stopwatch();
            watch.Start();
            var result = action();
            watch.Stop();
            return new Tuple<object, TimeSpan>(result, watch.Elapsed);
        }
    }
}