using System;

namespace CSharpCodeWars.Kyu4.PathFinder1CanYouReachTheExit;


// DFS Depth First Search
public class PathFinder1CanYouReachTheExit
{
    public bool PathFinder(string mazeAsString)
    {
        var maze = ConvertToArray(mazeAsString);

        var queue = new Stack<Position>();
        var seen = new HashSet<Position>();

        var size = maze.GetLength(0) - 1;

        var goalPos = new Position(size, size);
        var startPos = new Position(0, 0);
        seen.Add(startPos);
        queue.Push(startPos);

        while (queue.Any())
        {
            var current = queue.Pop();

            if (current.X == goalPos.X && current.Y == goalPos.Y)
            {
                return true;
            }

            var possibleMoves = new List<Position>();
            // N
            if (current.Y > 0 && maze[current.X, current.Y - 1] != 'W')
            {
                possibleMoves.Add(new Position(current.X, current.Y - 1));
            }

            // S
            if (current.Y < size && maze[current.X, current.Y + 1] != 'W')
            {
                possibleMoves.Add(new Position(current.X, current.Y + 1));
            }

            // W
            if (current.X > 0 && maze[current.X - 1, current.Y] != 'W')
            {
                possibleMoves.Add(new Position(current.X - 1, current.Y));
            }

            // E
            if (current.X < size && maze[current.X + 1, current.Y] != 'W')
            {
                possibleMoves.Add(new Position(current.X + 1, current.Y));
            }

            foreach (var child in possibleMoves.Where(pos => !seen.Contains(pos)))
            {
                seen.Add(child);
                queue.Push(child);
            }
        }

        return false;
    }

    private static char[,] ConvertToArray(string mazeAsString)
    {
        var lines = mazeAsString.Split("\n");
        var xLength = lines[0].Length;
        var yLength = lines.Length;

        var maze = new char[xLength, yLength];
        for (var y = 0; y < yLength; y++)
        {
            for (var x = 0; x < xLength; x++)
            {
                maze[y, x] = lines[y][x];
            }
        }

        return maze;
    }
}

record Position(int X, int Y);
