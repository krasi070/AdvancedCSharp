using System;
using System.Linq;

class CollectTheCoins
{
    static void Main()
    {
        char[][] board = new char[4][];
        for (int i = 0; i < 4; i++)
        {
            board[i] = Console.ReadLine().ToCharArray();
        }
        string commands = Console.ReadLine();
        int lastRow = 0;
        int lastCol = 0;
        int coinsCollected = 0;
        if (board[0][0] == '$')
        {
            coinsCollected++;
        }
        int wallsHit = 0;
        for (int i = 0; i < commands.Length; i++)
        {
            switch (commands[i])
            {
                case 'v':
                    if (lastRow < 3)
                    {
                        if (board[lastRow + 1].Length < lastCol)
                        {
                            wallsHit++;
                        }
                        else
                        {
                            if (board[lastRow + 1][lastCol] == '$')
                            {
                                coinsCollected++;
                            }
                            lastRow++;
                        }
                    }
                    else
                    {
                        wallsHit++;
                    }
                    break;
                case 'V':
                    if (lastRow < 3)
                    {
                        if (board[lastRow + 1].Length < lastCol)
                        {
                            wallsHit++;
                        }
                        else
                        {
                            if (board[lastRow + 1][lastCol] == '$')
                            {
                                coinsCollected++;
                            }
                            lastRow++;
                        }
                    }
                    else
                    {
                        wallsHit++;
                    }
                    break;
                case '>':
                    if (lastCol == board[lastRow].Length - 1)
                    {
                        wallsHit++;
                    }
                    else
                    {
                        if (board[lastRow][lastCol + 1] == '$')
                        {
                            coinsCollected++;
                        }
                        lastCol++;
                    }
                    break;
                case '<':
                    if (lastCol < 1)
	                {
		                wallsHit++;
	                }
                    else
	                {
                        if (board[lastRow][lastCol - 1] == '$')
                        {
                            coinsCollected++;
                        }
                        lastCol--;
	                }
                    break;
                case '^':
                    if (lastRow > 0)
                    {
                        if (board[lastRow - 1].Length < lastCol)
                        {
                            wallsHit++;
                        }
                        else
                        {
                            if (board[lastRow - 1][lastCol] == '$')
                            {
                                coinsCollected++;
                            }
                            lastRow--;
                        }
                    }
                    else
                    {
                        wallsHit++;
                    }
                    break;
            }
        }
        Console.WriteLine("Coins collected: {0}\nWalls hit: {1}", coinsCollected, wallsHit);
    }
}

