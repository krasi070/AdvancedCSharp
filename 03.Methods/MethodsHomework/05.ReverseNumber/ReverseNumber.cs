using System;
using System.Linq;

class ReverseNumber
{
    static void Main()
    {
        double inputNumber = double.Parse(Console.ReadLine());
        Console.WriteLine(GetReversedFloatingPointNumber(inputNumber));
    }
    static double GetReversedFloatingPointNumber(double number)
    {
        string strNumber = number.ToString();
        char[] reverseArr = strNumber.Reverse().ToArray();
        string reverse = "";
        for (int i = 0; i < reverseArr.Length; i++)
        {
            reverse += reverseArr[i].ToString();
        }
        double reversedNumber = double.Parse(reverse);
        return reversedNumber;
    }
}

