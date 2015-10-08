using System;
using System.Text;

public static class StringBuilderExtensions
{
    public static string Substring(this StringBuilder substring, int startIndex, int count)
    {
        string substringStr = "";
        for (int i = startIndex; i < count + startIndex; i++)
        {
            substringStr += substring[i];
        }
        return substringStr;
    }
}

