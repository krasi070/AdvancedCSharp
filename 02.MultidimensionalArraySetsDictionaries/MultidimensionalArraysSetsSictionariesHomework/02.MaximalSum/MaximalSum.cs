using System;

class MaximalSum
{
    static void Main()
    {
        string inputRowsCols = Console.ReadLine();
        int rows = int.Parse(inputRowsCols.Split()[0]);
        int cols = int.Parse(inputRowsCols.Split()[1]);
        int[,] matrix = new int[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            string currRow = Console.ReadLine();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = int.Parse(currRow.Split()[col]);
            }
        }
        int bestSum = int.MinValue;
        int bestRow = int.MinValue;
        int bestCol = int.MinValue;
        for (int row = 0; row < rows - 2; row++)
        {
            int currSum = 0;
            for (int col = 0; col < cols - 2; col++)
            {
                currSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (currSum > bestSum)
                {
                    bestSum = currSum;
                    bestRow = row;
                    bestCol = col;
                }
                currSum = 0;
            }
        }
        Console.WriteLine("Sum = {0}", bestSum);
        for (int row = bestRow; row < bestRow + 3; row++)
        {
            for (int col = bestCol; col < bestCol + 3; col++)
            {
                Console.Write("{0,-2} ", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }
}

