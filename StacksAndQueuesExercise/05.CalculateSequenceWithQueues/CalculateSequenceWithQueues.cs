namespace _05.CalculateSequenceWithQueues
{
    using System;
    using System.Collections.Generic;

    public class CalculateSequenceWithQueues
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            Queue<long> queue = new Queue<long>();
            queue.Enqueue(number);
            for (int i = 0; i < 50; i++)
            {
                long currNumber = queue.Dequeue();
                queue.Enqueue(currNumber + 1);
                queue.Enqueue(2*currNumber + 1);
                queue.Enqueue(currNumber + 2);

                Console.Write(currNumber + " ");
            }

            Console.WriteLine();
        }
    }
}