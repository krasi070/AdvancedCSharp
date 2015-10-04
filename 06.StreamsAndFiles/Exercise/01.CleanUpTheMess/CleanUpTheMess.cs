using System;
using System.IO;
using System.Text.RegularExpressions;

class CleanUpTheMess
{
    static void Main()
    {
        string programPath = "../../Mecanismo.cs";
        string enginePath = "../../Engine.cs";
        using (var writeMecanismo = new StreamWriter(enginePath)) 
        {
            using (var readMecanismo = new StreamReader(programPath))
            {
                string mecanismoStr = readMecanismo.ReadToEnd();
                string spaces = @"\s*\n\s*";
                string semiColumns = @";\s*";
                string openingCurlyBracket = @"\s*{\s*";
                string closingCurlyBracket = @"\s*}\s*";
                string dots = @"\s*\.\s*";

                mecanismoStr = Regex.Replace(mecanismoStr, spaces, "\n");
                mecanismoStr = Regex.Replace(mecanismoStr, semiColumns, ";\n");
                mecanismoStr = Regex.Replace(mecanismoStr, openingCurlyBracket, "\n{\n");
                mecanismoStr = Regex.Replace(mecanismoStr, closingCurlyBracket, "\n}\n");
                mecanismoStr = Regex.Replace(mecanismoStr, dots, ".");

                Console.WriteLine(mecanismoStr);

                string line = readMecanismo.ReadLine();
                while (line != null)
                {
                    for (int i = line.Length - 1; i >= 0; i--)
                    {
                        writeMecanismo.Write(line[i]);
                    }

                    writeMecanismo.WriteLine();
                    line = readMecanismo.ReadLine();
                }
            }
        }
    }
}

