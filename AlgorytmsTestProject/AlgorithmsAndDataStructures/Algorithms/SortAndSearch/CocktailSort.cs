using System;
using AlgorithmsAndDataStructures.Algorithms.Interfaces;
using AlgorithmsAndDataStructures.ServicesAndHelpers;

namespace AlgorithmsAndDataStructures.Algorithms.SortAndSearch
{
    public class CocktailSort : ISortStrategy
    {
        public T[] Sort<T>(T[] array, bool descending = true) where T : IComparable<T>
        {
            var copyArray = new T[array.Length];
            Array.Copy(array, copyArray, array.Length);

            //устанавливаем левую границу массива
            var left = 0;
            //устанавливаем правую границу массива
            var right = copyArray.Length - 1;
            //до тех пор, пока левая граница меньше или равна правой границы массива
            while (left <= right)
            {
                //пробегаем массив слева на право
                //начиная с элемента левой границы массива
                //и до границы правой без включения онной
                for (var i = left; i < right; i++)
                    //сравниваем текущий элемент с ПОСЛЕДУЮЩИМ элементом массива
                    //если текущий элемент БОЛЬШЕ, то
                    if (copyArray[i].CompareTo(copyArray[i + 1]) == 1)
                        copyArray.Swap(i, i + 1);
                //продвигаем границу справа на 1 единицу влево
                right--;
                //пробегаем массив справо на лево
                //начиная с элемента правой границы массива
                //и до границы левой без включения онной
                for (var j = right; j > left; j--)
                    //сравниваем текущий элемент с ПРЕДЫДУЩИМ элементом массива
                    //если текущий элемент МЕНЬШЕ, то
                    if (copyArray[j].CompareTo(copyArray[j - 1]) == -1)
                        copyArray.Swap(j - 1, j);
                //продвигаем границу слева на 1 единицу вправо
                left++;

                //тем самым двигая границы уменьшаем область сортировки
                //идем сразу с двух концов
            }

            return copyArray;
        }

        private void Swap<T>(T[] array, int currIndex, int swapIndex)
        {
            var temp = array[currIndex];
            array[currIndex] = array[swapIndex];
            array[swapIndex] = temp;
        }
    }
}