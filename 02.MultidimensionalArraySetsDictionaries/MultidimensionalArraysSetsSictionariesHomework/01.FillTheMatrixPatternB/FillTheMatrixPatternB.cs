using System;

class FillTheMatrixPatternB
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int number = 1;
        for (int col = 0; col < size; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < size; row++)
                {
                    matrix[row, col] = number;
                    number++;
                }
            }
            else
            {
                for (int row = size - 1; row >= 0; row--)
                {
                    matrix[row, col] = number;
                    number++;
                }
            }
        }
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write("{0,-3} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

