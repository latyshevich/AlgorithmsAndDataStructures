using System;
using AlgorithmsAndDataStructures.ServicesAndHelpers;

namespace AlgorithmsAndDataStructures.Algorithms.SortAndSearch
{
    public class GnomeSort
    {
        public T[] Sort<T>(T[] array) where T : IComparable<T>
        {
            var copyArray = new T[array.Length];
            Array.Copy(array, copyArray, array.Length);
            //начинаем всегда со второго элемента массива
            var i = 1;
            //до тех пор пока счетчик индекса меньше количества элементов
            //(проходим весь массив)
            while (i < copyArray.Length)
                //если это у нас первый элемент массива
                //или же предыдущий элемент массива меньше или равен текущему
                if (i == 0 || copyArray[i - 1].CompareTo(copyArray[i]) == -1 ||
                    copyArray[i - 1].CompareTo(copyArray[i]) == 0)
                {
                    //увеличиваем счетчик
                    i++;
                }
                else
                {
                    //иначе
                    //рядом стоящие элементы стоят в не отсортированном порядке
                    //а значит меняем их местами (текущий и предыдущий элементы)
                    //а счетчик уменьшаем на 1
                    //тем самым начинаем следующую итерацию с того же эелемента по значению
                    //(так как поменял текущий элемент и предстоящий местами)
                    //но с индексом на единицу меньше
                    //(продвигаем элемент не удовлетворяющий условию в начало массива, до тех пор пока не наталкнемся на элемент меньше текущего)
                    copyArray.Swap(i, i - 1);
                    i--;
                }

            return copyArray;
        }
    }
}