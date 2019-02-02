using System;

namespace AlgorithmsAndDataStructures.Algorithms.SortAndSearch
{
    public class InsertionSort
    {
        public T[] Sort<T>(T[] array, bool descending = true) where T : IComparable<T>
        {
            var copyArray = new T[array.Length];
            Array.Copy(array, copyArray, array.Length);
            //если по убыванию, то -1, иначе по возрастанию 1
            var descOrAsc = descending ? -1 : 1;
            //для каждого элемента массива начиная со второго и до конца
            for (var i = 1; i < copyArray.Length; i++)
            {
                //для текущего элемента заводим временную переменную
                //так как в процессе сдвига мы значение элемента в текущей позиции потеряем
                var currElement = copyArray[i];
                int j;
                //для каждого элемента, начиная с элемента предшествующего текущему элементу, и до начала массива
                //то есть двигаемся по подмассиву перед текущим элементом справа на лево
                //и до тех пор пока элемент из этого подмассива меньше (больше) текущего элемента
                for (j = i - 1; j >= 0 && copyArray[j].CompareTo(currElement) == descOrAsc; j--)
                    //сдвигаем текущий элемент подмассива на одну позицию следующей за ним
                    copyArray[j + 1] = copyArray[j];
                //на том месте подмассива где перестали выполняться условия 
                //(дошли до начала подмассива или же нашли элемент в подмассиве больше(меньше) текущего)
                //вставляем наш текущий запомненый элемент
                copyArray[j + 1] = currElement;
            }

            return copyArray;
        }
    }
}