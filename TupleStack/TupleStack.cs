using System;

namespace TupleStack
{
    //A simple implementation of a stack using C#'s new TupleValues
    public class TupleStack<T>
    {
        private (object, T) data;
        public int Depth { get; private set; }

        public TupleStack()
        {
            data = (null, default(T));
            Depth = 0;
        }

        public void Push(T item)
        {
            data = (data, item);
            Depth++;
        }

        public T Pop()
        {
            if (data.Item1 == null)
            {
                throw new NullReferenceException("Stack empty");
            }

            T item = data.Item2;
            data = ((object, T))data.Item1;
            Depth--;
            return item;
        }

        public T Peek()
        {
            return data.Item2;
        }
    }
}
