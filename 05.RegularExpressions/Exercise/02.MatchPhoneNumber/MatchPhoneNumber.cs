using System;
using System.Text.RegularExpressions;

class MatchPhoneNumber
{
    static void Main()
    {
        Console.Write("Enter phone number:");
        string phoneNum = Console.ReadLine();
        string pattern = @"[+][3][5][9]( |-)[2]\1\d{3}\1\d{4}\b";
        Regex regex = new Regex(pattern);
        Console.WriteLine(regex.IsMatch(phoneNum));
    }
}

