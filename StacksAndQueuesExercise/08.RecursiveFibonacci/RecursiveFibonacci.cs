namespace _08.RecursiveFibonacci
{
    using System;
    using System.Collections.Generic;

    public class RecursiveFibonacci
    {
        private static Dictionary<long, long> fib = new Dictionary<long, long>(); 

        public static void Main()
        {
            long n = long.Parse(Console.ReadLine());
            long fibonacci = GetFibonacci(n);
            Console.WriteLine(fibonacci);
        }

        private static long GetFibonacci(long n)
        {
            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return 1;
            }

            if (!fib.ContainsKey(n))
            {
                long currFib = GetFibonacci(n - 1) + GetFibonacci(n - 2);
                fib.Add(n, currFib);
                return currFib;
            }
            else
            {
                return fib[n];
            }
        }
    }
}