using System;

namespace CSharpCodeWars.Kyu3.PathFinder3TheAlpinist
{
    public class PathFinder3TheAlpinist
    {
        public int PathFinder(string mazeAsString)
        {
            var maze = ConvertToArray(mazeAsString);
            var open = new Queue<Position>();
            var seen = new HashSet<Position>();

            var width = maze.GetLength(0) - 1; 
            var height = maze.GetLength(0) - 1;
            
            var goalPos = new Position(width, height, -1);
            var startPos = new Position(0, 0, 0);
            seen.Add(startPos);
            open.Enqueue(startPos);

            var currentBest = int.MaxValue;
            while (open.Any())
            {
                var current = open.Dequeue();

                if (current.X == goalPos.X && current.Y == goalPos.Y && current.Count < currentBest)
                {
                    if (current.Count < currentBest)
                    {
                        currentBest = current.Count;
                    }
                }

                var possibleMoves = new List<Position>();
                // N
                if (current.Y > 0)
                {
                    var difference = Math.Abs( maze[current.X, current.Y] - maze[current.X, current.Y - 1]);
                    possibleMoves.Add(new Position(current.X, current.Y - 1, current.Count + difference));
                }
                
                // S
                if (current.Y < height)
                {
                    var difference = Math.Abs(maze[current.X, current.Y] - maze[current.X, current.Y + 1]);
                    possibleMoves.Add(new Position(current.X, current.Y + 1, current.Count + difference));
                }
                
                // W
                if (current.X > 0)
                {
                    var difference = Math.Abs(maze[current.X, current.Y] - maze[current.X - 1, current.Y]);
                    possibleMoves.Add(new Position(current.X - 1, current.Y, current.Count + difference));
                }
                
                // E
                if (current.X < width)
                {
                    var difference = Math.Abs(maze[current.X, current.Y] - maze[current.X + 1, current.Y]);
                    possibleMoves.Add(new Position(current.X + 1, current.Y, current.Count + difference));
                }

                foreach (var child in possibleMoves.Where(pos => !HasSeen(seen, pos)))
                {
                    seen.Add(child);
                    open.Enqueue(child);
                }
            }

            return currentBest;
        }
        

        private static bool HasSeen(HashSet<Position> positions, Position pos)
        {
            return positions.Any(seenPos => seenPos.X == pos.X && seenPos.Y == pos.Y && seenPos.Count <= pos.Count);
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
                    maze[y, x] = int.Parse(lines[y][x].ToString());
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
            return X == other.X && Y == other.Y && Count == other.Count;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() ^ Y.GetHashCode();
        }
    }
}
