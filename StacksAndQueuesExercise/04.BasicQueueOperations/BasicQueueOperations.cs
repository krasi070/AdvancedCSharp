namespace _04.BasicQueueOperations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class BasicQueueOperations
    {
        public static void Main()
        {
            int[] args = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int numberOfElements = args[0];
            int elementsToDequeue = args[1];
            int elementToSearchFor = args[2];

            Queue<int> queue = new Queue<int>();
            int[] numbers = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            for (int i = 0; i < numberOfElements; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < elementsToDequeue; i++)
            {
                queue.Dequeue();
            }

            int min = int.MaxValue;
            if (queue.Count > 0)
            {
                while (queue.Count > 0)
                {
                    int currElement = queue.Dequeue();
                    if (currElement == elementToSearchFor)
                    {
                        Console.WriteLine("true");
                        return;
                    }

                    if (currElement < min)
                    {
                        min = currElement;
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