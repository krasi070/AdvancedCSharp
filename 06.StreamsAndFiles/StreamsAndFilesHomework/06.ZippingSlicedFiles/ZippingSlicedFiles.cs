using System;
using System.IO;
using System.IO.Compression;

class SlicingFile
{
    static void Main()
    {
        int parts = int.Parse(Console.ReadLine());
        SliceAndCompress("../../text.txt", parts);
        AssembleAndDecompress("../../assembled-text.txt", parts);
    }
    static void SliceAndCompress(string destinationDirectory, int parts)
    {
        using (var sourceFile = new FileStream(destinationDirectory, FileMode.Open))
        {
            long partLength = sourceFile.Length / parts;
            long lastPartLength = (sourceFile.Length % parts) + (sourceFile.Length / parts);
            for (int i = 0; i < parts; i++)
            {
                using (var destination = new FileStream("../../Part " + (i + 1).ToString() + ".gz", FileMode.Create))
                {
                    using (var compressedDestination = new GZipStream(destination, CompressionMode.Compress))
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
                        compressedDestination.Write(buffer, 0, buffer.Length);
                    }
                }
            }
        }
    }
    static void AssembleAndDecompress(string destinationDirectory,int parts)
    {
        for (int i = 0; i < parts; i++)
        {
            using (var compressedDestination = new FileStream("../../Part " + (i + 1).ToString() + ".gz", FileMode.Open))
            {
                using (var decompressedDestination = new GZipStream(compressedDestination, CompressionMode.Decompress))
                {
                    using (var assembledDestination = new FileStream(destinationDirectory, FileMode.Append))
                    {
                        byte[] buffer = new byte[4096];
                        int readBytes = decompressedDestination.Read(buffer, 0, buffer.Length);
                        while (true)
                        {
                            if (readBytes == 0)
                            {
                                break;
                            }
                            assembledDestination.Write(buffer, 0, readBytes);
                            readBytes = decompressedDestination.Read(buffer, 0, buffer.Length);
                        }
                    }
                }
            }
        }
    }
}

