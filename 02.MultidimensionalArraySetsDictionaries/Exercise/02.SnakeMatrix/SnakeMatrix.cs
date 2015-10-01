using System;

class SnakeMatrix
{
    static void Main(string[] args)
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        int[,] matrix = new int[rows, cols];
        int result = 1;
        for (int row = 0; row < rows; row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = result;
                    result++;
                }
            }
            else
            {
                for (int col = cols - 1; col >= 0; col--)
                {
                    matrix[row, col] = result;
                    result++;
                }
            }
        }
        for (int row = 0; row < rows; row++)
        {
            for (int col= 0; col < cols; col++)
            {
                Console.Write("{0,-3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

