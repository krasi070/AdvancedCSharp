using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

class DirectoryTraversal
{
    static void Main()
    {
        string input = Console.ReadLine();
        List<FileInfo> files = Directory.GetFiles(input).Select(file => new FileInfo(file)).ToList();
        var sortedFiles = files.OrderBy(file => file.Length).GroupBy(file => file.Extension).OrderByDescending(group => group.Count()).ThenBy(file => file.Key);
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt";
        using (var textWriter = new StreamWriter(path))
        {
            foreach (var group in sortedFiles)
            {
                textWriter.WriteLine(group.Key);
                foreach (var file in group)
                {
                    textWriter.WriteLine("--{0} - {1:F3}kb", file.Name, file.Length / 1024.0);
                }
            }  
        }
    }
}

