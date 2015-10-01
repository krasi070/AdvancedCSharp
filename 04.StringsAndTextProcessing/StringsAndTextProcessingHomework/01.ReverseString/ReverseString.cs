using System;
using System.Linq;

class ReverseString
{
    static void Main()
    {
        string inputstr = Console.ReadLine();
        for (int i = inputstr.Length - 1; i >= 0; i--) 
        {
            Console.Write(inputstr[i]);
        }
        Console.WriteLine();
    }
}

