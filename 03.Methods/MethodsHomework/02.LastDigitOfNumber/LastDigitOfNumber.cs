using System;

class LastDigitOfNumber
{
    static void Main()
    {
        int inputNumber = int.Parse(Console.ReadLine());
        Console.WriteLine(LastDigitAsEnglishWord(inputNumber));
    }
    static string LastDigitAsEnglishWord(int number)
    {
        number %= 10;
        string digitAsWord;
        switch (number)
        {
            case 1:
                digitAsWord = "one";
                break;
            case 2:
                digitAsWord = "two";
                break;
            case 3:
                digitAsWord = "three";
                break;
            case 4:
                digitAsWord = "four";
                break;
            case 5:
                digitAsWord = "five";
                break;
            case 6:
                digitAsWord = "six";
                break;
            case 7:
                digitAsWord = "seven";
                break;
            case 8:
                digitAsWord = "eight";
                break;
            case 9:
                digitAsWord = "nine";
                break;
            default:
                digitAsWord = "zero";
                break;
        }
        return digitAsWord;
    }
}

