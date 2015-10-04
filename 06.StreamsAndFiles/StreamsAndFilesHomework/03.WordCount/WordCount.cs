using System;
using System.IO;
using System.Collections.Generic;

class WordCount
{
    static void Main()
    {
        List<string> words = new List<string>();
        using (var readWords = new StreamReader("../../words.txt"))
        {
            string currWord = readWords.ReadLine();
            while (true)
            {
                if (currWord == null)
                {
                    break;
                }
                words.Add(currWord);
                currWord = readWords.ReadLine();
            }
        }
        int[] counters = new int[words.Count];
        using (var readText = new StreamReader("../../text.txt"))
        {
            string currLine = readText.ReadLine();
            while (true)
            {
                if (currLine == null)
                {
                    break;
                }
                string[] wordsInLine = currLine.Split(new string[] { " ", "\n", "\t", "!", ".", "?", "-" },
                    StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < words.Count; i++)
                {
                    for (int j = 0; j < wordsInLine.Length; j++)
                    {
                        if (words[i].ToLower() == wordsInLine[j].ToLower())
                        {
                            counters[i]++;
                        }
                    }
                }
                currLine = readText.ReadLine();
            }
        }
        string[] results = new string[words.Count];
        for (int i = 0; i < words.Count; i++)
        {
            results[i] = words[i] + " - " + counters[i];
        }
        for (int i = 0; i < words.Count; i++)
        {
            for (int j = 0; j < words.Count; j++)
            {
                string temp = "";
                if (Convert.ToInt32(results[i][results[i].Length - 1]) > Convert.ToInt32(results[j][results[j].Length - 1]))
                {
                    temp = results[i];
                    results[i] = results[j];
                    results[j] = temp;
                }
            }
        }
        using (var writeResults = new StreamWriter("../../result.txt"))
        {
            for (int i = 0; i < results.Length; i++)
            {
                writeResults.WriteLine(results[i]);
            }
        }
    }
}

