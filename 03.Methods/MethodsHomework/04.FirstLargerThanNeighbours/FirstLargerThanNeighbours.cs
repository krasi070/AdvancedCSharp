using System;

class FirstLargerThanNeighbours
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
        Console.WriteLine(GetIndexOfFirstLargerThanNeighbourElement(arr));
    }
    static int GetIndexOfFirstLargerThanNeighbourElement(int[] array)
    {
        int index = -1;
        for (int i = 0; i < array.Length; i++)
        {
            if (i != 0 && i != array.Length - 1)
            {
                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    index = i;
                    break;
                }
            }
            else
            {
                if (i == 0)
                {
                    if (array[i] > array[i + 1])
                    {
                        index = i;
                        break;
                    }
                }
                if (i == array.Length - 1)
                {
                    if (array[i] > array[i - 1])
                    {
                        index = i;
                        break;
                    }
                }
            }
        }
        return index;
    }
}

