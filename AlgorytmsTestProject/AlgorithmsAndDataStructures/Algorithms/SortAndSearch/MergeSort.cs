using System;

namespace AlgorithmsAndDataStructures.Algorithms.SortAndSearch
{
    /// <summary>
    ///     Сортировка слиянием
    /// </summary>
    public class MergeSort
    {
        public T[] Sort<T>(T[] array) where T : IComparable<T>
        {
            var copyArray = new T[array.Length];
            Array.Copy(array, copyArray, array.Length);
            return MergeSortIn(copyArray, 0, copyArray.Length - 1);
        }

        private T[] MergeSortIn<T>(T[] array, int beginIndex, int endIndex) where T : IComparable<T>
        {
            //если начальный индекс подмассива больше или равен конечному
            //то есть в подмассиве только один элемент
            if (beginIndex >= endIndex)
                return array; //то возвращаем наш массив
            //в ином случаи находим индекс серидинного элемента подмассива
            //то есть делим наш подмассив на две равные части
            var middleIndex = (beginIndex + endIndex) / 2;
            //рекурсивно вызываем текущий метод
            //и передаем туда индексы на два новых подмассива
            //то есть прожолжаем делить исходный массив на подмассивы до тех пор пока в подмассивах не останется по одному элементу
            var firstPart = MergeSortIn(array, beginIndex, middleIndex);
            var secondPart = MergeSortIn(array, middleIndex + 1, endIndex);
            //самые интерсные вещи происходят в методе слияния
            return Merge(array, beginIndex, middleIndex, endIndex);
        }

        private T[] Merge<T>(T[] array, int beginIndex, int middleIndex, int endIndex) where T : IComparable<T>
        {
            //НА ВХОД: 
            //  Исходный массив
            //  начальный индекс подмассива в исходном массиве
            //  индекс элемента, который делит подмассив на две равные части
            //  конечный индекс подмассива
            //НА ВЫХОДЕ:
            //  массив в котором лежат уже отсортированные элементы входного подмассива от индекса beginIndex до endIndex

            //Метод слияния является рабочей лошадкой всего метода сортировки Слиянием
            //получаем кол-во элементов из первого подмассива 
            var n1 = middleIndex - beginIndex + 1;
            //получаем кол-во элементов из второго подмассива 
            var n2 = endIndex - (middleIndex + 1) + 1;
            //создаем два новых массива с кол-вом элементов на один элемент больше чем в полученных подмассивах
            var arrayB = new T[n1 + 1];
            var arrayC = new T[n2 + 1];

            Array.Copy(array, beginIndex, arrayB, 0, n1);
            Array.Copy(array, middleIndex + 1, arrayC, 0, n2);
            //TODO: дурацкая реализация. Так как мы заранее не знаем какой тип к нам придет мы не можем 
            //устанавить в последний элемент массивов B и C значение Infinity
            //Поэтому сразу будим проверять на последний элемент массива
            var i = 0;
            var j = 0;
            for (var k = beginIndex; k <= endIndex; k++)
                if (i != n1 && j != n2 && (arrayB[i].CompareTo(arrayC[j]) == -1 || arrayB[i].CompareTo(arrayC[j]) == 0))
                {
                    array[k] = arrayB[i];
                    i++;
                }
                else if (j != n2)
                {
                    array[k] = arrayC[j];
                    j++;
                }
                else if (i != n1)
                {
                    array[k] = arrayB[i];
                    i++;
                }

            return array;
        }
    }
}