using System.Data;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace TicTacToeLib
{

  public class TicTacToe
  {
    public const char NONE = ' ';
    public const char CROSS = 'X';
    public const char CIRCLE = 'O';
    public const int SIZE = 3;

    public static char StartNewGame(int size, out char[,] grid)
    {
      grid = new char [size, size];
      for (int row = 0; row < grid.GetLength(0); row++)
      {
        for (int column = 0; column < grid.GetLength(1); column++)
        {
          grid[row, column] = NONE;
        }
      }
      return CROSS;
    }

    public static char PutMarkAt(int column, int row, char[,] grid, char currentPlayer)
    {
      //Modification de l'ordre des variables row (x) et column (y).
      //2 Tests échoues... Les tests devoient etre modifier aussi.
      if (grid[column, row] == NONE)
      { 
        grid[column, row] = currentPlayer;
        if (currentPlayer == CROSS)
        {
          currentPlayer = CIRCLE;
        }
        else
        {
          currentPlayer = CROSS;
        }
      }
      return currentPlayer;
    }

    public static char FindWinner(char[,] grid)
    {
      int squareArrayLen = grid.GetLength(0);
      
      bool isWinningMainDiagonal = true;
      bool isWinningSecondaryDiagonal = true;

      /*rows and columns*/ 
      for (int i = 0; i < squareArrayLen; i++)
      {
        bool isWinningRow = grid[i, 0] != NONE;
        bool isWinningColumn = grid[0, i] != NONE;

        for(int j = 0; j < squareArrayLen; j++)
        {
          if (grid[i, j] != grid[i, 0])
          {
            isWinningRow = false;
          }
          if (grid[j, i] != grid[0, i])
          {
            isWinningColumn = false;
          }
        }
        if (isWinningRow)
        {
          return grid[i, 0];
        }
        if (isWinningColumn)
        {
          return grid[0, i];
        }
        /*Diagonals check*/
        if (grid[i,i] != grid[0, 0])
        {
          isWinningMainDiagonal = false;
        }
        if (grid[i, squareArrayLen -1 -i] != grid[0, squareArrayLen -1])
        {
          isWinningSecondaryDiagonal = false;
        }
      }

      /*Diagonals check*/
      if (grid[0, 0] != NONE && isWinningMainDiagonal)
      {
        return grid[0, 0];
      }
      if (grid[0, squareArrayLen - 1] != NONE && isWinningSecondaryDiagonal)
      {
        return grid[0, squareArrayLen - 1];
      }
      
      return NONE;
    }

    public static bool IsGameADraw(char[,] grid)
    {
      if (FindWinner(grid) != NONE)
      {
        return false;
      }
      for (int i= 0; i < grid.GetLength(0); i++)
      {
        for (int j = 0; j < grid.GetLength(1); j++)
        {
          if (grid[i, j] == NONE)
          {
            return false;
          }
        }
      }
      return true;
    }
  }
}