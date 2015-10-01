using System;
using System.Linq;

class LargerThanNeighbours
{
    static void Main()
    {
        Console.Write("Enter N integers on a single line divided by a space: ");
        string inputArr = Console.ReadLine();
        int[] arr = new int[inputArr.Split().Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(inputArr.Split()[i]);
        }
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbour(arr, i));
        }
    }
    static bool IsLargerThanNeighbour(int[] array, int index)
    {
        bool isLarger = false;
        if (index != 0 && index != array.Length - 1)
        {
            if (array[index] > array[index - 1] && array[index] > array[index + 1])
            {
                isLarger = true;
            }
            else
            {
                isLarger = false;
            }
        }
        else
        {
            if (index == 0)
            {
                if (array[index] > array[index + 1])
                {
                    isLarger = true;
                }
                else
                {
                    isLarger = false;
                }
            }
            if (index == array.Length - 1)
            {
                if (array[index] > array[index - 1])
                {
                    isLarger = true;
                }
                else
                {
                    isLarger = false;
                }
            }
        }
        return isLarger;
    }
}

