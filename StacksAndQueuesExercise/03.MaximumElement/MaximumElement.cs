namespace _03.MaximumElement
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MaximumElement
    {
        public static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            Stack<long> stack = new Stack<long>();

            long max = long.MinValue;
            for (int i = 0; i < numberOfLines; i++)
            {
                int[] args = Console.ReadLine()
                    .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int type = args[0];
                switch (type)
                {
                    case 1:
                        int numberToPush = args[1];
                        stack.Push(numberToPush);
                        if (numberToPush > max)
                        {
                            max = numberToPush;
                        }
                        break;
                    case 2:
                        stack.Pop();
                        if (!stack.Contains(max))
                        {
                            max = stack.Max();
                        }
                        break;
                    case 3:
                        Console.WriteLine(max);
                        break;
                }
            }
        }
    }
}