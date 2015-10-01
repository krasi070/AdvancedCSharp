using System;

class CountSubstringOccurrences
{
    static void Main()
    {
        string inputStr = Console.ReadLine().ToLower();
        string inputSubstring = Console.ReadLine().ToLower();
        int numOfOccurrences = 0;
        for (int i = 0; i < inputStr.Length - (inputSubstring.Length - 1); i++)
        {
            int count = 0;
            if (inputStr[i] == inputSubstring[0])
            {
                for (int j = 0; j < inputSubstring.Length; j++)
                {
                    if (inputStr[i + j] == inputSubstring[j])
                    {
                        count++;
                    }
                }
            }
            if (count == inputSubstring.Length)
            {
                numOfOccurrences++;
            }
        }
        Console.WriteLine(numOfOccurrences);
    }
}

