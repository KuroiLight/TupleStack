using System;

using TupleStack;

namespace tupletest
{
    class Program
    {
        static void Main(string[] args)
        {
            TupleStack<int> tsInt = new TupleStack<int>();
            tsInt.Push(int.Parse(Console.ReadLine()));
            tsInt.Push(int.Parse(Console.ReadLine()));
            Console.WriteLine(tsInt.Pop());
            Console.WriteLine(tsInt.Pop());
            Console.ReadLine();
        }
    }
}
