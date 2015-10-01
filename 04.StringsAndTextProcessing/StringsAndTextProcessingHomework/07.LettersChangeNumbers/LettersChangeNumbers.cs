//Hi! When I put my code into the judge system it gave me 70/100. I couldn't find my mistake. 
//So if you have enough time and patience, I would be very grateful if you could find my mistake. Thanks in advance!

using System;
using System.Collections.Generic;

class LettersChangeNumbers
{
    static void Main()
    {
        string inputStr = Console.ReadLine();
        List<string> inputs = new List<string>();
        for (int i = 0; i < inputStr.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries).Length; i++)
        {
            inputs.Add(inputStr.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)[i]);
        }
        string numStr = "";
        double result = 0;
        for (int i = 0; i < inputs.Count; i++)
        {
            for (int j = 1; j < inputs[i].Length - 1; j++)
            {
                numStr += inputs[i][j];
            }
            double num = Convert.ToDouble(numStr);
            result += CalculateResult(inputs[i][0], num, inputs[i][inputs[i].Length - 1]);
            numStr = "";
        }
        Console.WriteLine("{0:F2}", result);
    }
    static double CalculateResult(char fstLetter, double num, char lstLetter)
    {
        double result = 0;
        int temp = 0;
        if (fstLetter >= 97 && fstLetter <= 122)
        {
            temp = Convert.ToInt32(fstLetter);
            result += (Convert.ToDouble(temp) - 96) * num;
        }
        else if (fstLetter >=65 && fstLetter <= 90)
        {
            temp = Convert.ToInt32(fstLetter);
            result += num / (Convert.ToDouble(temp) - 64);
        }
        if (lstLetter >= 97 && lstLetter <= 122)
        {
            temp = Convert.ToInt32(lstLetter);
            result += Convert.ToDouble(temp) - 96;
        }
        else if (lstLetter >= 65 && lstLetter <= 90)
        {
            temp = Convert.ToInt32(lstLetter);
            result -= Convert.ToDouble(temp) - 64;
        }
        return result;
    }
}

