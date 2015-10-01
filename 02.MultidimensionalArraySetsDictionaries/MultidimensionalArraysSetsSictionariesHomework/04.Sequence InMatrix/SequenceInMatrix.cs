using System;

class SequenceInMatrix
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());
        string[,] matrix = new string[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            string currRow = Console.ReadLine();
            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = currRow.Split()[col];
            }
        }
        int longestSequence = 0;
        int currSequence = 1;
        int rowNow = 0;
        int colNow = 0;
        string bestStr = "";
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols - 1; col++)
            {
                if (matrix[row, col] == matrix[row, col + 1])
                {
                    currSequence++;
                    rowNow = row;
                    colNow = col;
                }
                else
                {
                    currSequence = 1;
                }
                if (longestSequence < currSequence)
                {
                    longestSequence = currSequence;
                    bestStr = matrix[rowNow, colNow];
                }
            }
        }
        for (int col = 0; col < cols; col++)
        {
            for (int row = 0; row < rows - 1; row++)
            {
                if (matrix[row, col] == matrix[row + 1, col])
                {
                    currSequence++;
                    rowNow = row;
                    colNow = col;
                }
                else
                {
                    currSequence = 1;
                }
                if (longestSequence < currSequence)
                {
                    longestSequence = currSequence;
                    bestStr = matrix[rowNow, colNow];
                }
            }  
        }
        currSequence = 1;
        int limit;
        if (rows == cols)
        {
            limit = rows;
        }
        else
        {
            limit = Math.Max(rows, cols) - 1;
        }
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                for (int i = 1; i < limit - (row + col); i++)
                {
                    if (matrix[row, col] == matrix[row + i, col + i])
                    {
                        currSequence++;
                        rowNow = row;
                        colNow = col;
                    }
                    else
                    {
                        currSequence = 1;
                    }
                    if (longestSequence < currSequence)
                    {
                        longestSequence = currSequence;
                        bestStr = matrix[rowNow, colNow];
                    }
                }
            }
        }
        string[,] matrix2 = new string[rows, cols];
        for (int row = 0, i = rows - 1; row < rows; row++, i--)
        {
            for (int col = 0, j = cols - 1; col < cols; col++, j--)
            {
                matrix2[row, col] = matrix[i, j]; 
            }
        }
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                for (int i = 1; i < limit - (row + col); i++)
                {
                    if (matrix2[row, col] == matrix2[row + i, col + i])
                    {
                        currSequence++;
                        rowNow = row;
                        colNow = col;
                    }
                    else
                    {
                        currSequence = 1;
                    }
                    if (longestSequence < currSequence)
                    {
                        longestSequence = currSequence;
                        bestStr = matrix2[rowNow, colNow];
                    }
                }
            }
        }
        for (int i = 0; i < longestSequence; i++)
        {
            Console.Write(bestStr);
            if (i != longestSequence - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine();
    }
}

