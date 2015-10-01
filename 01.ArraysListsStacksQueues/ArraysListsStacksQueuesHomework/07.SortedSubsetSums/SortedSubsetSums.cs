using System;
using System.Collections.Generic;
using System.Linq;

class SortedSubsetSums
{
    static void Main()
    {
        int inputNum = int.Parse(Console.ReadLine());
        int[] arr = Console.ReadLine().Split().Select(int.Parse).Distinct().ToArray();
        bool noMatches = true;
        List<int> list = new List<int>();
        List<string> results = new List<string>();
        List<string> operands = new List<string>();
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
                results.Add(string.Join(" + ", list) + " = " + Convert.ToString(inputNum));
                noMatches = false;
                operands.Add(string.Join(" ", list));
            }
            list.Clear();
        }
        if (noMatches)
        {
            Console.WriteLine("No matching subsets.");
        }
        int min = int.MaxValue;
        int index = 0;
        List<string> newResults = new List<string>();
        List<string> tempList = new List<string>();
        List<string> tempOpernadsList = new List<string>();
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = 0; j < results.Count; j++)
            {
                int counter = results[j].Count(Char.IsWhiteSpace) / 2;
                if (counter == i)
                {
                    tempList.Add(results[j]);
                    tempOpernadsList.Add(operands[j]);
                }
            }
            while (tempList.Count > 0)
            {
                for (int j = 0; j < tempList.Count; j++)
                {
                    int currNum = tempOpernadsList[j].Split().Select(int.Parse).ToArray().Min();
                    if (currNum < min)
                    {
                        min = currNum;
                        index = j;
                    }
                }
                newResults.Add(tempList[index]);
                tempList.RemoveAt(index);
                tempOpernadsList.RemoveAt(index);
                min = int.MaxValue;
            }
        }
        newResults.ForEach(a => Console.WriteLine(a));
    }
}

