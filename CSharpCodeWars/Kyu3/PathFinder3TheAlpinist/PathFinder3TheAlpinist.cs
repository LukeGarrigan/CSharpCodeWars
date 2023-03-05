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
            
            var goalPos = new Position(size, size, -1, 0);
            var startPos = new Position(0, 0, 0, 0 );
            closed.Add(startPos);
            open.Enqueue(startPos, startPos.F);

            while (open.TryDequeue(out var current, out _))
            {
                closed.Add(current);
                
                if (current.X == goalPos.X && current.Y == goalPos.Y)
                {
                    return current.Count;
                }

                foreach (var child in GetNeighbours(current, maze, size, closed))
                {
                    open.Enqueue(child, child.F);   
                }
            }

            return -1;
        }

        private static List<Position> GetNeighbours(Position current, int[,] maze, int size, HashSet<Position> closed)
        {
            var possibleMoves = new List<Position>();
            // N
            if (current.Y > 0)
            {
                var difference = Math.Abs(maze[current.X, current.Y] - maze[current.X, current.Y - 1]);
                var f = CalculateF(current.X, current.Y - 1, size, current.Count + difference);
                var child = new Position(current.X, current.Y - 1, current.Count + difference, f);
                if (!HasSeen(closed, child))
                {
                    possibleMoves.Add(child);    
                }
                
            }

            // S
            if (current.Y < size)
            {
                var difference = Math.Abs(maze[current.X, current.Y] - maze[current.X, current.Y + 1]);
                var f = CalculateF(current.X, current.Y + 1, size, current.Count + difference);
                var child = new Position(current.X, current.Y + 1, current.Count + difference, f);
                if (!HasSeen(closed, child))
                {
                    possibleMoves.Add(child);    
                }
            }

            // W
            if (current.X > 0)
            {
                var difference = Math.Abs(maze[current.X, current.Y] - maze[current.X - 1, current.Y]);
                var f = CalculateF(current.X - 1, current.Y, size, current.Count + difference);
                var child = new Position(current.X - 1, current.Y, current.Count + difference, f);
                if (!HasSeen(closed, child))
                {
                    possibleMoves.Add(child);    
                }
            }

            // E
            if (current.X < size)
            {
                var difference = Math.Abs(maze[current.X, current.Y] - maze[current.X + 1, current.Y]);
                var f = CalculateF(current.X + 1, current.Y, size, current.Count + difference);
                var child = new Position(current.X + 1, current.Y, current.Count + difference, f);
                if (!HasSeen(closed, child))
                {
                    possibleMoves.Add(child);    
                }
            }

            return possibleMoves;
        }

        private static int CalculateF(int currentX, int currentY, int size, int currentCost)
        {
            var manhattanDistance = Math.Abs(currentX - size) + Math.Abs(currentY - size);
            return currentCost + manhattanDistance;
        }


        private static bool HasSeen(IEnumerable<Position> positions, Position pos)
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
        
        public Position(int x, int y, int count, int f)
        {
            X = x;
            Y = y;
            Count = count;
            F = f;
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
