using System;
using System.Collections.Generic;

class MatrixShuffling
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }
        List<string> commands = new List<string>();
        do
        {
            commands.Add(Console.ReadLine());
        } while (commands[commands.Count - 1] != "END");
        commands.RemoveAt(commands.Count - 1);
        for (int i = 0; i < commands.Count; i++)
        {
            if ((commands[i].Split().Length != 5) || (commands[i].Split()[0] != "swap"))
            {
                Console.WriteLine("Invalid input!");
            }
            else
	        {
                int x1 = int.Parse(commands[i].Split()[1]);
                int y1 = int.Parse(commands[i].Split()[2]);
                int x2 = int.Parse(commands[i].Split()[3]);
                int y2 = int.Parse(commands[i].Split()[4]);
                if (x1 < rows && x2 < rows && y1 < cols && y2 < cols)
                {
                    Console.WriteLine("(after swapping {0} and {1}): ", matrix[x1, y1], matrix[x2, y2]);
                    string temp = matrix[x1, y1];
                    matrix[x1, y1] = matrix[x2, y2];
                    matrix[x2, y2] = temp;
                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write("{0,-2} ", matrix[row, col]);
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
	        }
        }
    }
}

