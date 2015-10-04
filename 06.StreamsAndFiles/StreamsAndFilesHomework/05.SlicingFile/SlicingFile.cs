using System;
using System.IO;

class SlicingFile
{
    static void Main()
    {
        int parts = int.Parse(Console.ReadLine());
        Slice("../../text.txt", parts);
        Assemble("../../assembled-text.txt", parts);
    }
    static void Slice(string destinationDirectory, int parts)
    {
        using (var sourceFile = new FileStream(destinationDirectory, FileMode.Open))
        {
        long partLength = sourceFile.Length / parts;
        long lastPartLength = (sourceFile.Length % parts) + (sourceFile.Length / parts);
        for (int i = 0; i < parts; i++)
        {
            using (var destination = new FileStream("../../Part " + (i + 1).ToString() + ".txt", FileMode.Create))
            {
                byte[] buffer;
                if (i == parts - 1)
                {
                    buffer = new byte[lastPartLength];
                }
                else
                {
                    buffer = new byte[partLength];
                }
                sourceFile.Read(buffer, 0, buffer.Length);
                destination.Write(buffer, 0, buffer.Length);
            } 
        }
        }
    }
    static void Assemble(string destinationDirectory, int parts)
    {
        using (var assembledDestination = new FileStream(destinationDirectory, FileMode.Create))
        {
            for (int i = 0; i < parts; i++)
            {
                using (var destination = new FileStream("../../Part " + (i + 1).ToString() + ".txt", FileMode.Open))
                {
                    byte[] buffer = new byte[destination.Length];
                    destination.Read(buffer, 0, buffer.Length);
                    assembledDestination.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}

