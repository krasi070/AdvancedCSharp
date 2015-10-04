using System;
using System.IO;

class LineNumbers
{
    static void Main()
    {
        using (var readLines = new StreamReader("../../I don't have numbered lines.txt"))
        {
            using (var writeLines = new StreamWriter("../../I have numbered lines.txt"))
            {
                int currLineNumber = 1;
                string currLineText = readLines.ReadLine();
                while (true)
                {
                    writeLines.WriteLine("{0}. {1}", currLineNumber, currLineText);
                    currLineText = readLines.ReadLine();
                    if (currLineText == null)
                    {
                        break;
                    }
                    currLineNumber++;

                }
            }
        }
    }
}

