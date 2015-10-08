using System;
using System.Text;

class ExtendTheStringBuilderClass
{
    public static void Main()
    {
        StringBuilder alphabet = new StringBuilder();
        for (int i = 0; i < 26; i++)
        {
            alphabet.Append((char)('a' + i));
        }
        Console.WriteLine(alphabet.Substring(10, 10));
    }
}

