namespace _01.ReverseNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ReverseNumbers
    {
        public static void Main()
        {
            Stack<int> stack = new Stack<int>();
            int[] numbers = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            foreach (var number in numbers)
            {
                stack.Push(number);
            }

            while (stack.Count > 0)
            {
                Console.Write(stack.Pop() + " ");
            }

            Console.WriteLine();
        }
    }
}