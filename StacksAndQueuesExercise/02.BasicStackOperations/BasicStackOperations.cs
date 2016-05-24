namespace _02.BasicStackOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicStackOperations
    {
        public static void Main()
        {
            int[] args = Console.ReadLine()
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int numberOfElements = args[0];
            int elementsToPop = args[1];
            int elementToSearchFor = args[2];

            Stack<int> stack = new Stack<int>();
            int[] numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < numberOfElements; i++)
            {
                int currNumber = numbers[i];
                stack.Push(currNumber);
            }

            for (int i = 0; i < elementsToPop; i++)
            {
                stack.Pop();
            }

            int min = int.MaxValue;
            if (stack.Count > 0)
            {
                while (stack.Count > 0)
                {
                    int poppedElement = stack.Pop();
                    if (poppedElement == elementToSearchFor)
                    {
                        Console.WriteLine("true");
                        return;
                    }

                    if (poppedElement < min)
                    {
                        min = poppedElement;
                    }
                }
            }
            else
            {
                Console.WriteLine(0);
                return;
            }

            Console.WriteLine(min);
        }
    }
}