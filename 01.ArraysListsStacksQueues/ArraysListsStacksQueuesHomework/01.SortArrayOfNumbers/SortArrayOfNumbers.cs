using System;

class SortArrayOfNumbers
{
    static void Main()
    {
        string inputNumbers = Console.ReadLine();
        double[] arr = new double[inputNumbers.Split().Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = double.Parse(inputNumbers.Split()[i]);
        }
        Array.Sort(arr);
        Console.WriteLine(string.Join(" ", arr));
    }
}

