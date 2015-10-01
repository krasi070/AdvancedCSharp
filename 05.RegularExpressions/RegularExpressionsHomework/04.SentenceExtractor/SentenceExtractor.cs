using System;
using System.Text.RegularExpressions;

class SentenceExtractor
{
    static void Main()
    {
        string keyword = Console.ReadLine();
        string text = Console.ReadLine();
        string pattern = @"(?:\s|^)((([^.?!]*\s" + keyword + @"\s[^.?!]*)[.?!])|([^.?!]*" + keyword + "[.?!]))";
        Regex regex = new Regex(pattern);
        MatchCollection matches = regex.Matches(text);
        foreach (Match match in matches)
        {
            Console.WriteLine(match.Groups[0]);
        }
    }
}

