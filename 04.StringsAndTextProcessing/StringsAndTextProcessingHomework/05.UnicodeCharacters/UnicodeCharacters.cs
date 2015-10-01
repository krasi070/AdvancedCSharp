using System;

class UnicodeCharacters
{
    static void Main()
    {
        char[] inputStr = Console.ReadLine().ToCharArray();
        string[] hexNum = new string[inputStr.Length];
        for (int i = 0; i < hexNum.Length; i++)
        {
            int decNum = 0;
            decNum = Convert.ToInt32(inputStr[i]);
            hexNum[i] = decNum.ToString("X").ToLower();
            Console.Write("\\u00{0}", hexNum[i]);
        }
        Console.WriteLine();
    }
}

