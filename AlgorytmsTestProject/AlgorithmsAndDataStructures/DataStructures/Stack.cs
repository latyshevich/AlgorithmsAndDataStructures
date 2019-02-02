namespace AlgorithmsAndDataStructures.DataStructures
{
    public class Stack<T>
    {
        private T[] stack;

        public Stack() : this(10)
        {
        }

        public Stack(int capacity)
        {
            stack = new T[capacity];
        }
    }
}