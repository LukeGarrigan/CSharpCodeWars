using System;

namespace CSharpCodeWars.Kyu3.PathFinder3TheAlpinist
{
    public class PathFinder3TheAlpinist
    {
        public int PathFinder(string mazeAsString)
        {
            var maze = ConvertToArray(mazeAsString);
            var open = new List<Position>();
            var closed = new HashSet<Position>();

            var width = maze.GetLength(0) - 1; 
            var height = maze.GetLength(0) - 1;
            
            var goalPos = new Position(width, height, -1, 0);
            var startPos = new Position(0, 0, 0, 0 );
            closed.Add(startPos);
            open.Add(startPos);

            while (open.Any())
            {
                var current = open.OrderBy(s => s.F).First();

                open.Remove(current);
                closed.Add(current);
                
                if (current.X == goalPos.X && current.Y == goalPos.Y )
                {
                    return current.Count;
                }

                var possibleMoves = GetNeighbours(current, maze, height, width);

                foreach (var child in possibleMoves.Where(pos => !HasSeen(closed, pos)))
                {
                    closed.Add(child);

                    var existingChild = open.FirstOrDefault(o => o.X == child.X && o.Y == child.Y);
                    
                    if (existingChild == null || existingChild.Count > child.Count)
                    {
                        open.Add(child);   
                    }
                }
            }

            return -1;
        }

        private static List<Position> GetNeighbours(Position current, int[,] maze, int height, int width)
        {
            var possibleMoves = new List<Position>();
            // N
            if (current.Y > 0)
            {
                var difference = Math.Abs(maze[current.X, current.Y] - maze[current.X, current.Y - 1]);
                var f = CalculateF(current.X, current.Y - 1, maze, current.Count + difference);
                possibleMoves.Add(new Position(current.X, current.Y - 1, current.Count + difference, f));
            }

            // S
            if (current.Y < height)
            {
                var difference = Math.Abs(maze[current.X, current.Y] - maze[current.X, current.Y + 1]);
                
                var f = CalculateF(current.X, current.Y + 1, maze, current.Count + difference);
                possibleMoves.Add(new Position(current.X, current.Y + 1, current.Count + difference, f));
            }

            // W
            if (current.X > 0)
            {
                var difference = Math.Abs(maze[current.X, current.Y] - maze[current.X - 1, current.Y]);
                var f = CalculateF(current.X - 1, current.Y, maze, current.Count + difference);
                possibleMoves.Add(new Position(current.X - 1, current.Y, current.Count + difference, f));
            }

            // E
            if (current.X < width)
            {
                var difference = Math.Abs(maze[current.X, current.Y] - maze[current.X + 1, current.Y]);
                var f = CalculateF(current.X + 1, current.Y, maze, current.Count + difference);
                possibleMoves.Add(new Position(current.X + 1, current.Y, current.Count + difference, f));
            }

            return possibleMoves;
        }

        private static int CalculateF(int currentX, int currentY, int[,] maze, int currentCost)
        {
            var manhattanDistance = Math.Abs(currentX - ((maze.GetLength(0) - 1))) + Math.Abs(currentY - (maze.GetLength(0) - 1));
            return currentCost + manhattanDistance;
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
