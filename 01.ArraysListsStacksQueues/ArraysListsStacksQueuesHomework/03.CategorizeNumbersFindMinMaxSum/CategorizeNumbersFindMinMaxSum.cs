using System;
using System.Collections.Generic;
using System.Linq;

class CategorizeNumbersFindMinMaxSum
{
    static void Main()
    {
        string inputNumbers = Console.ReadLine();
        List<double> floatingPointList = new List<double>();
        List<double> integerList = new List<double>();
        double isInt;
        for (int i = 0; i < inputNumbers.Split().Length; i++)
        {
            isInt = (double.Parse(inputNumbers.Split()[i]) * 10) % 10;
            if (isInt == 0)
            {
                integerList.Add(double.Parse(inputNumbers.Split()[i]));
            }
            else
            {
                floatingPointList.Add(double.Parse(inputNumbers.Split()[i]));
            }
        }
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",
            string.Join(", ", floatingPointList), floatingPointList.Min(), floatingPointList.Max(), floatingPointList.Sum(),
            floatingPointList.Average());
        Console.WriteLine("[{0}] -> min: {1}, max: {2}, sum: {3}, avg: {4:F2}",
            string.Join(", ", integerList), integerList.Min(), integerList.Max(), integerList.Sum(), integerList.Average());
    }
}

