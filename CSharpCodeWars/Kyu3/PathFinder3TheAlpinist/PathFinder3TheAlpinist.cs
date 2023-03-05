using System;

namespace CSharpCodeWars.Kyu3.PathFinder3TheAlpinist
{
    public class PathFinder3TheAlpinist
    {
        public int PathFinder(string mazeAsString)
        {
            var maze = ConvertToArray(mazeAsString);
            var open = new PriorityQueue<Position, int>();
            var closed = new HashSet<Position>();

            var size = maze.GetLength(0) - 1; 
            
            var goalPos = new Position(size, size, -1);
            var startPos = new Position(0, 0, 0);
            closed.Add(startPos);
            open.Enqueue(startPos, 0);

            while (open.Count > 0)
            {
                var current = open.Dequeue();
                closed.Add(current);
                
                if (current.Equals(goalPos))
                {
                    return current.Count;
                }
                
                foreach (var child in GetNeighbours(current, maze, size).Where(pos => !closed.Contains(pos)))
                {
                    open.Enqueue(child, child.Count);   
                }
            }

            return -1;
        }

        private static IEnumerable<Position> GetNeighbours(Position current, int[,] maze, int size)
        {
            var possibleMoves = new List<Position>();
            // N
            if (current.Y > 0)
            {
                var difference = Math.Abs(maze[current.X, current.Y] - maze[current.X, current.Y - 1]);
                possibleMoves.Add(new Position(current.X, current.Y - 1, current.Count + difference));
            }

            // S
            if (current.Y < size)
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
            if (current.X < size)
            {
                var difference = Math.Abs(maze[current.X, current.Y] - maze[current.X + 1, current.Y]);
                possibleMoves.Add(new Position(current.X + 1, current.Y, current.Count + difference));
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

    class Position 
    {

        public int X { get; set; }
        public int Y { get; set; }
        public int Count { get; set; }
        public int F { get; set; }
        
        public Position(int x, int y, int count)
        {
            X = x;
            Y = y;
            Count = count;
        }
        

        public override bool Equals(object obj)
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
