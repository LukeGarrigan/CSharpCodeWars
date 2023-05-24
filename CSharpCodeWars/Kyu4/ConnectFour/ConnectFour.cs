using System;

namespace CSharpCodeWars.Kyu4.ConnectFour;

public class ConnectFour
{
    private int[,] grid; 
    
    public string WhoIsWinner(List<string> pieces)
    {
        grid = new int[6, 7];
        foreach (var piece in pieces)
        {
            var column = ToColumn(piece.Split("_")[0]);
            var colour = piece.Split("_")[1];

            var colourValue = colour == "Red" ? 1 : -1;

            var (x, y) = PlacePiece(column, colourValue);
            if (IsWinner(x, y))
            {
                return colour;

            }
        }

        return "";
    }

    private bool CheckNeighbours(int colour, int row, int column, int rowDelta, int columnDelta)
    {
        var neighbours = 0;

        var currentColumn = column;
        var currentRow = row;
        while (true)
        {
            currentColumn += columnDelta;
            currentRow += rowDelta;
            if (currentColumn < 0 || currentRow < 0 || currentRow >= grid.GetLength(0) || currentColumn >= grid.GetLength(0))
            {
                break;
            }

            if (grid[currentRow, currentColumn] == colour)
            {
                neighbours++;
            }
            else
            {
                break;
            }
        }
        
        currentColumn = column;
        currentRow = row;
        while (true)
        {
            currentColumn -= columnDelta;
            currentRow -= rowDelta;
            if (currentColumn < 0 || currentRow < 0 || currentRow >= grid.GetLength(0) || currentColumn >= grid.GetLength(0))
            {
                break;
            }

            if (grid[currentRow, currentColumn] == colour)
            {
                neighbours++;
            }
            else
            {
                break;
            }
        }
  
        if (neighbours >= 3)
        {
            return true;
        }

        return false;
    }

    private bool IsWinner(int row, int column)
    {
        var colour = grid[row, column];
        return CheckNeighbours(colour, row, column, 0, 1) ||
               CheckNeighbours(colour, row, column, 1, 0) || 
               CheckNeighbours(colour, row, column, 1, 1) || 
               CheckNeighbours(colour, row, column, 1, -1);
    }

    private int ToColumn(string letter) => "ABCDEFG".IndexOf(letter, StringComparison.Ordinal);

    private (int row, int column) PlacePiece(int column, int colourValue)
    {
        var rows = grid.GetLength(0) - 1;

        for (var i = rows; i >= 0; i--)
        {
            if (grid[i, column] == 0)
            {
                grid[i, column] = colourValue;
                return (i, column);
            }
        }

        return (-1, -1);
    }
}
