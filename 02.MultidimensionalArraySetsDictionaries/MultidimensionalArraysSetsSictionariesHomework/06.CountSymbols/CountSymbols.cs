using System;
using System.Collections.Generic;
using System.Linq;

class CountSymbols
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        List<char> listChar = new List<char>();
        int[] arr = new int[inputStr.Length];
        for (int i = 0; i < inputStr.Length; i++)
        {
            listChar.Add(inputStr[i]);
            
        }
        listChar.Sort();
        List<string> listStr = new List<string>();
        foreach (var element in listChar)
        {
            listStr.Add(Convert.ToString(element));
        }
        for (int i = 0; i < listStr.Count; i++)
        {
            for (int j = 0; j < listStr.Count; j++)
            {
                if (listStr[i] == listStr[j])
                {
                    arr[i]++;
                }
            }
        }
        for (int i = 0; i < listStr.Count; i++)
        {
            listStr[i] += " " + Convert.ToString(arr[i]);
        }
        for (int i = 0; i < listStr.Count; i++)
        {
            for (int j = 0; j < listStr.Count; j++)
            {
                if (i == j)
                {
                    continue;
                }
                if (listStr[i] == listStr[j])
                {
                    listStr.RemoveAt(j);
                    j = 0;
                }
            }
        }
        for (int i = 0; i < listStr.Count; i++)
        {
            Console.Write("{0}: ", listStr[i][0]);
            for (int j = 2; j < listStr[i].Length; j++)
            {
                Console.Write(listStr[i][j]);
            }
            Console.WriteLine(" time/s");
        }
    }
}

