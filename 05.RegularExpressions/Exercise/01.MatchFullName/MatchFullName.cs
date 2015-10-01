using System;
using System.Text.RegularExpressions;

class MatchFullName
{
    static void Main()
    {
        Console.Write("Enter your full name: ");
        string fullName = Console.ReadLine();
        string pattern = @"\b[A-Z]{1}[a-z]{1,} [A-Z]{1}[a-z]{1,}\b";
        Regex regex = new Regex(pattern);
        Console.WriteLine(regex.IsMatch(fullName));
    }
}

