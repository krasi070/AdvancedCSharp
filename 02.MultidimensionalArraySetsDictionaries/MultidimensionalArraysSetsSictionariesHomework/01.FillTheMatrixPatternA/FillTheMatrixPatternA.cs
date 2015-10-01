using System;

class FillTheMatrixPatternA
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int number = 1;
        for (int col = 0; col < size; col++)
        {
            for (int row = 0; row < size; row++)
            {
                matrix[row, col] = number;
                number++;
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

