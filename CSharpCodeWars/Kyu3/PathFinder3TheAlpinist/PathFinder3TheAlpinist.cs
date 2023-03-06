using System;

namespace CSharpCodeWars.Kyu3.PathFinder3TheAlpinist;

public class PathFinder3TheAlpinist
{
    public int PathFinder(string mazeAsString)
    {
        var maze = ConvertToArray(mazeAsString);

        var priorities = new int[maze.Length, maze.Length];
        
        for (var y = 0; y < maze.Length; y++)
        {
            for (var x = 0; x < maze.Length; x++)
            {
                priorities[x, y] = int.MaxValue;
            }
        }
        
        var open = new PriorityQueue<Position, int>();
        var size = maze.GetLength(0) - 1; 
            
        var goalPos = new Position(size, size);
        var startPos = new Position(0, 0);
        open.Enqueue(startPos, 0);

        while (open.TryDequeue(out var current, out var priority))
        {
            if (current.Equals(goalPos))
            {
                return priority;
            }
                
            foreach (var child in GetNeighbours(current, size))
            {
                var difference = Math.Abs(maze[current.X, current.Y] - maze[child.X, child.Y]);

                var childCost = priority + difference;
                if (childCost < priorities[child.X, child.Y])
                {
                    priorities[child.X, child.Y] = childCost;
                    open.Enqueue(child, childCost);   
                }
            }
        }

        return -1;
    }

    private static IEnumerable<Position> GetNeighbours(
        Position current, int size)
    {
        var possibleMoves = new HashSet<Position>();
        // N
        if (current.Y > 0)
        {
            possibleMoves.Add(new Position(current.X, current.Y - 1));
        }

        // S
        if (current.Y < size)
        {
            possibleMoves.Add(new Position(current.X, current.Y + 1));
        }

        // W
        if (current.X > 0)
        {
            possibleMoves.Add(new Position(current.X - 1, current.Y));
        }

        // E
        if (current.X < size)
        {
            possibleMoves.Add(new Position(current.X + 1, current.Y));
        }

        return possibleMoves;
    }

    private static int[,] ConvertToArray(string mazeAsString)
    {
        var lines = mazeAsString.Split("\n");
        var xLength = lines[0].Length;
        var yLength = lines.Length;

        var maze = new int[xLength, yLength];

        for (var y = 0; y < yLength; y++)
        {
            for (var x = 0; x < xLength; x++)
            {
                int.TryParse(lines[y][x].ToString(), out maze[y, x]);
            }
        }

        return maze;
    }
}

record Position(int X, int Y);