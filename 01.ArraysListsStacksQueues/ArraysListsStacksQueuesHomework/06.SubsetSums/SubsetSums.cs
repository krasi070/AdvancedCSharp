using System;
using System.Collections.Generic;
using System.Linq;

class SubsetSums
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();
        bool noMatches = true;
        List<int> list = new List<int>();
        for (int i = 1; i < Math.Pow(2, arr.Length); i++)
        {
            for (int j = 0; j < arr.Length; j++)
            {
                if ((i >> j & 1) != 0)
                {
                    list.Add(arr[j]);
                }
            }
            if (list.Sum() == inputNum)
            {
                Console.WriteLine("{0} = {1}", string.Join(" + ", list), inputNum);
                noMatches = false;
            }
            list.Clear();
        }
        if (noMatches)
        {
            Console.WriteLine("No matching subsets.");
        }
    }
}

