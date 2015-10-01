using System;
using System.Collections.Generic;

class LongestIncreasingSequence
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        int[] arr = new int[inputStr.Split().Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(inputStr.Split()[i]);
        }
        string result = "";
        string temp = "";
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
            temp += Convert.ToString(arr[i]) + " ";
            if (result.Split().Length < temp.Split().Length)
            {
                result = temp;
            }
            if (i == arr.Length - 1)
            {
                continue;
            }
            if (arr[i] >= arr[i + 1])
            {
                Console.WriteLine();
                temp = "";
            }
        }
        Console.WriteLine();
        Console.WriteLine("Longest: {0}", result);
    }
}

