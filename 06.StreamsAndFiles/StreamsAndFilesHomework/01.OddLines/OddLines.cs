using System;
using System.IO;

class OddLines
{
    static void Main()
    {
        using (var textReader = new StreamReader("../../Text.txt"))
        {
            int currLine = 0;
            string line = "";
            do
	        {
                line = textReader.ReadLine();
                if (currLine % 2 == 1)
                {
                    Console.WriteLine(line);
                }
                currLine++;
            } while (line != null);
        }
    }
}

