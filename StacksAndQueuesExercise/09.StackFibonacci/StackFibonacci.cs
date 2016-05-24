namespace _09.StackFibonacci
{
    using System;
    using System.Collections.Generic;

    public class StackFibonacci
    {
        public static void Main()
        {
            long n = int.Parse(Console.ReadLine());
            var stack = new Stack<long>();
            stack.Push(1);
            stack.Push(1);
            for (int i = 3; i <= n; i++)
            {
                long nMinusOne = stack.Pop();
                long nMinusTwo = stack.Peek();
                stack.Push(nMinusOne);
                stack.Push(nMinusOne + nMinusTwo);
            }

            Console.WriteLine(stack.Peek());
        }
    }
}