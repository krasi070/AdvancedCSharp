using System;

class TextFilter
{
    static void Main()
    {
        string banList = Console.ReadLine();
        string text = Console.ReadLine();
        string[] bannedWords = new string[banList.Split().Length];
        string[] result = new string[bannedWords.Length + 1];
        for (int i = 0; i < bannedWords.Length ; i++)
        {
            bannedWords[i] = banList.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)[i];
        }
        result[0] = text;
        for (int i = 1; i < result.Length; i++)
        {
            result[i] = result[i - 1].Replace(bannedWords[i - 1], new string('*', bannedWords[i - 1].Length));
        }
        Console.WriteLine(result[result.Length - 1]);
    }
}

