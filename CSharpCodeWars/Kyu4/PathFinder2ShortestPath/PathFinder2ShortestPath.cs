using System;
using System.Collections;
using System.Reflection.Metadata;

namespace CSharpCodeWars.Kyu4.PathFinder2ShortestPath
{
    public class PathFinder2ShortestPath
    {
        public int PathFinder(string mazeAsString)
        {
            var maze = ConvertToArray(mazeAsString);


            var queue = new Queue<Position>();
            var seen = new List<Position>();


            var width = maze.GetLength(0) - 1; // unsure atm if different width/height is pos
            var height = maze.GetLength(0) - 1;
            
            var goalPos = new Position(width, height, -1);
            var startPos = new Position(0, 0, 0);
            seen.Add(startPos);
            queue.Enqueue(startPos);

            while (queue.Any())
            {
                var current = queue.Dequeue();

                if (Equals(current, goalPos))
                {
                    return current.Count;
                }

                var possibleMoves = new List<Position>();
                // N
                if (current.Y > 0 && maze[current.X, current.Y - 1] != 'W')
                {
                    possibleMoves.Add(new Position(current.X, current.Y - 1, current.Count + 1));
                }
                
                // S
                if (current.Y < height && maze[current.X, current.Y + 1] != 'W')
                {
                    possibleMoves.Add(new Position(current.X, current.Y + 1, current.Count + 1));
                }
                
                // W
                if (current.X > 0 && maze[current.X -1, current.Y] != 'W')
                {
                    possibleMoves.Add(new Position(current.X - 1, current.Y, current.Count + 1));
                }
                
                // E
                if (current.X < width && maze[current.X + 1, current.Y] != 'W')
                {
                    possibleMoves.Add(new Position(current.X + 1, current.Y, current.Count + 1));
                }

                foreach (var child in possibleMoves.Where(pos => !seen.Contains(pos)))
                {
                    seen.Add(child);
                    queue.Enqueue(child);
                }
            }

            return -1;
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

    class Position
    {

        public int X { get; set; }
        public int Y { get; set; }
        public int Count { get; set; }
        public Position(int x, int y, int count)
        {
            X = x;
            Y = y;
            Count = count;
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Position))
            {
                return false;
            }

            var other = (Position)obj;
            return X == other.X && Y == other.Y;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }

    }

}
