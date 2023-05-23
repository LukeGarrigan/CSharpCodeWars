using System;

namespace CSharpCodeWars.Kyu4.ConnectFour;

public class ConnectFour
{
    private int[,] grid; 
    
    public string WhoIsWinner(List<string> pieces)
    {
        grid = new int[6, 7];
        PrintArray();

        foreach (var piece in pieces)
        {
            var column = ToColumn(piece.Split("_")[0]);
            var colour = piece.Split("_")[1];

            var colourValue = colour == "Red" ? 1 : -1;

            var (x, y) = PlacePiece(column, colourValue);
            

            PrintArray();
            
            if (IsWinner(x, y))
            {
                return colour;

            }
        }

        return "";
    }

    private bool IsWinner(int row, int column)
    {
        var colour = grid[row, column];
        // COLUMN NEIGHBOURS
        int columnNeighbours = 0;

        for (var i = column + 1; i < grid.GetLength(1); i++)
        {
            if (grid[row, i] == colour)
            {
                columnNeighbours++;
            }
            else
            {
                break;
            }
        }
        
        for (var i = column - 1; i >= 0; i--)
        {
            if (grid[row, i] == colour)
            {
                columnNeighbours++;
            }
            else
            {
                break;
            }
        }

        if (columnNeighbours == 3)
        {
            return true;
        }

        // ROW NEIGHBOURS
        var rowNeighbours = 0;
        
        for (var i = row + 1; i < grid.GetLength(0); i++)
        {
            if (grid[i, column] == colour)
            {
                rowNeighbours++;
            }
            else
            {
                break;
            }
        }
        
        for (var i = row - 1; i >= 0; i--)
        {
            if (grid[i, column] == colour)
            {
                rowNeighbours++;
            }
            else
            {
                break;
            }
        }

        if (rowNeighbours == 3)
        {
            return true;
        }
        
        
        // DIAGONAL RIGHT
        var diagonalRightNeighbours = 0;

        var currentColumn = column;
        var currentRow = row;
        while (true)
        {
            currentColumn++;
            currentRow--;
            if (currentColumn >= grid.GetLength(1) || currentRow < 0)
            {
                break;
            }

            if (grid[currentRow, currentColumn] == colour)
            {
                diagonalRightNeighbours++;
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
            currentColumn--;
            currentRow++;
            if (currentRow >= grid.GetLength(0) || currentColumn < 0)
            {
                break;
            }

            if (grid[currentRow, currentColumn] == colour)
            {
                diagonalRightNeighbours++;
            }
            else
            {
                break;
            }
        }
  
        if (diagonalRightNeighbours == 3)
        {
            return true;
        }

        // DIAGONAL LEFT
        var diagonalLeftNeighbours = 0;

        currentColumn = column;
        currentRow = row;
        while (true)
        {
            currentColumn--;
            currentRow--;
            if (currentColumn < 0 || currentRow < 0)
            {
                break;
            }

            if (grid[currentRow, currentColumn] == colour)
            {
                diagonalLeftNeighbours++;
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
            currentColumn++;
            currentRow++;
            if (currentRow >= grid.GetLength(0) || currentColumn >= grid.GetLength(0) )
            {
                break;
            }

            if (grid[currentRow, currentColumn] == colour)
            {
                diagonalLeftNeighbours++;
            }
            else
            {
                break;
            }
        }
  
        if (diagonalLeftNeighbours == 3)
        {
            return true;
        }

        return false;
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


    public void PrintArray()
    {
        Console.WriteLine();
        for (var i = 0; i < grid.GetLength(0); i++)
        {
            for (var j = 0; j < grid.GetLength(1); j++)
            {
                Console.Write(grid[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}
