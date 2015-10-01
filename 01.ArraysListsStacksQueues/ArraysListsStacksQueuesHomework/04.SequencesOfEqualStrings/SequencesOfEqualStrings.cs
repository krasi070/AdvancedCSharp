using System;

class SequencesOfEqualStrings
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        for (int i = 0; i < inputStr.Split().Length; i++)
        {
            Console.Write(inputStr.Split()[i] + " ");
            if (i == inputStr.Split().Length - 1)
            {
                continue;
            }
            if (inputStr.Split()[i] != inputStr.Split()[i + 1])
            {
                Console.WriteLine();
            }
        }
        Console.WriteLine();
    }
}

