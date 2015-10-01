using System;
using System.Text.RegularExpressions;

class ReplaceTag
{
    static void Main()
    {
        string inputHTML = Console.ReadLine();
        string pattern = @"<a.*href=((?:.|\n)*?(?=>))>((?:.|\n)*?(?=<))<\/a>";
        Regex regex = new Regex(pattern);
        Console.WriteLine(regex.Replace(inputHTML, @"[URL href=$1]$2[/URL]"));
    }
}
