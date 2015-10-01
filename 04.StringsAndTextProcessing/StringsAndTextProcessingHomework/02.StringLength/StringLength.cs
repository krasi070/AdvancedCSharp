using System;

class StringLength
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        for (int i = 0; i < 20; i++)
        {
            if (i < inputStr.Length)
            {
                Console.Write(inputStr[i]);
            }
            else
            {
                Console.Write("*");
            }
        }
        Console.WriteLine();
    }
}

