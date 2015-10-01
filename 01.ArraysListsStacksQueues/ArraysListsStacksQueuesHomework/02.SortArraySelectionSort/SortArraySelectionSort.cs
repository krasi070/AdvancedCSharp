using System;

class SortArraySelectionSort
{
    static void Main()
    {
        string inputNumbers = Console.ReadLine();
        double[] arr = new double[inputNumbers.Split().Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = double.Parse(inputNumbers.Split()[i]);
        }
        for (int i = 0; i < arr.Length; i++)
        {
            double minimumLeft = arr[i];
            int temp = 0;
            double temp2;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < minimumLeft)
                {
                    minimumLeft = arr[j];
                    temp = j;
                }
            }
            if (minimumLeft < arr[i])
            {
                temp2 = arr[i];
                arr[i] = arr[temp];
                arr[temp] = temp2;
            }
        }
        Console.WriteLine(string.Join(" ", arr));
    }
}

