using System;

class MatrixMultiplication
{
    static void Main()
    {
        Console.Write("First Matrix(rows, cols): ");
        string inputFstRowsCols = Console.ReadLine();
        Console.Write("Second Matrix(rows, cols): ");
        string inputSndRowsCols = Console.ReadLine();
        int fstRows = int.Parse(inputFstRowsCols.Split()[0]);
        int fstCols = int.Parse(inputFstRowsCols.Split()[1]);
        int sndRows = int.Parse(inputSndRowsCols.Split()[0]);
        int sndCols = int.Parse(inputSndRowsCols.Split()[1]);
        if ((fstRows == sndCols) || (fstCols == sndRows))
        {
            int[,] firstMatrix = new int[fstRows, fstCols];
            int[,] secondMatrix = new int[sndRows, sndCols];
            for (int i = 0; i < fstRows; i++)
            {
                for (int j = 0; j < fstCols; j++)
                {
                    Console.Write("FirstMatrix[{0}, {1}]: ", i, j);
                    firstMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < sndRows; i++)
            {
                for (int j = 0; j < sndCols; j++)
                {
                    Console.Write("SecondMatrix[{0}, {1}]: ", i, j);
                    secondMatrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            int[,] multiMatrix;
            int row;
            int col;
            int index;
            if (fstRows == sndCols)
            {
                multiMatrix = new int[sndRows, fstCols];
                row = sndRows;
                col = fstCols;
                index = fstRows;
            }
            else
            {
                multiMatrix = new int[fstRows, sndCols];
                row = fstRows;
                col = sndCols;
                index = sndRows;
            }
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    for (int k = 0; k < index; k++)
                    {
                        multiMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
                    }
                    Console.Write("{0,-3}", multiMatrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("These matrixes cannot be multiplied!");
        }
    }
}

