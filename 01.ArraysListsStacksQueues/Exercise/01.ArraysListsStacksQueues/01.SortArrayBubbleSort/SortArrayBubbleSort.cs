using System;
using System.Linq;

class SortArrayBubbleSort
{
    static void Main()
    {
        string inputString = Console.ReadLine();
        int counter = inputString.Count(Char.IsWhiteSpace) + 1;
        int[] intArr = new int[counter];
        for (int i = 0; i < counter; i++)
        {
            intArr[i] = int.Parse(inputString.Split()[i]);
        }
        int index = 0;
        int temp;
        int isSorted = 0;
        while (true)
        {
            if (intArr[index] > intArr[index + 1])
            {
                temp = intArr[index];
                intArr[index] = intArr[index + 1];
                intArr[index + 1] = temp;
            }
            else
            {
                isSorted++;
            }
            index++;
            if (index == counter - 1)
            {
                index = 0;
                if (isSorted == counter - 1)
                {
                    break;
                }
                else
                {
                    isSorted = 0;
                }
            }
        }
        Console.WriteLine("[{0}]",string.Join(", ", intArr));
    }
}

