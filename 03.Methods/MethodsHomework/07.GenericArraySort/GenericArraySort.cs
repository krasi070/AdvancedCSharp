using System;
using System.Collections.Generic;
using System.Linq;

class GenericArraySort
{
    static void Main()
    {
        int[] arrInt = { 5, 6, 3, 12, 54, 1, 3, 0 };
        string[] arrStr = { "haha", "jojo", "ivan", "asen" };
        DateTime[] arrDateTime = 
        {
            new DateTime(1999, 12, 13), new DateTime(2002, 12, 12), new DateTime(2015, 10, 11)
        };
        Console.WriteLine(SortArray(arrInt));
        Console.WriteLine(SortArray(arrStr));
        Console.WriteLine(SortArray(arrDateTime));
    }
    static string SortArray<T>(T[] arr)
    {
        List<T> tempList = arr.ToList();
        List<T> sortedList = new List<T>();
        while (tempList.Count > 0)
        {
            var currMin = tempList.Min();
            sortedList.Add(currMin);
            tempList.Remove(currMin);
        }
        string sortedArr = string.Join(", ", sortedList);
        return sortedArr;
    }
}

