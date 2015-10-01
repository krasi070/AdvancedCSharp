using System;

class UppercaseCharsEvenPositions
{
    static void Main()
    {
        string input = Console.ReadLine();
        Console.WriteLine(UppercaseCharsAtEvenPositions(input));
    }
    static string UppercaseCharsAtEvenPositions(string inputStr)
    {
        char[] arr = inputStr.ToCharArray();
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0 && arr[i] >= 97 && arr[i] <= 122) 
            {
                arr[i] -= Convert.ToChar('a' - 'A');
            }
        }
        arr.ToString();
        return new string(arr);
    }
}

