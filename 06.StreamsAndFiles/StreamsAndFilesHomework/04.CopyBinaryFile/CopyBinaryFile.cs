using System;
using System.IO;

class CopyBinaryFile
{
    static void Main()
    {
        using (var image = new FileStream("../../undertale.jpg", FileMode.Open))
        {
            using (var copy = new FileStream("../../undertale-copy.jpg", FileMode.Create))
            {
                byte[] buffer = new byte[4096];
                while (true)
                {
                    int readBytes = image.Read(buffer, 0, buffer.Length);
                    if (readBytes == 0)
                    {
                        break;
                    }
                    copy.Write(buffer, 0, readBytes);
                }
            }
        }
    }
}

