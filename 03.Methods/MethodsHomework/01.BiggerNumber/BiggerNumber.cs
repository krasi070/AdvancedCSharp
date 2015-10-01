using System;

class BiggerNumber
{
    static void Main()
    {
        int firstInput = int.Parse(Console.ReadLine());
        int secondInput = int.Parse(Console.ReadLine());
        Console.WriteLine(GetMax(firstInput, secondInput));
    }
    static int GetMax(int firstNumber, int secondNumber)
    {
        int max;
        if (firstNumber >= secondNumber)
        {
            max = firstNumber;
        }
        else
        {
            max = secondNumber;
        }
        return max;
    }
}

