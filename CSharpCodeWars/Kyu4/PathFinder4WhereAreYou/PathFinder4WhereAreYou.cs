using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace CSharpCodeWars.Kyu4.PathFinder4WhereAreYou
{
    public static class PathFinder4WhereAreYou
    {
        private static char[] directions = new char[] {'N', 'E', 'S', 'W'};
        private static int dirIndex = 0;
        private static Point currentPosition = new Point(0, 0);
        
        public static Point IAmHere(string input)
        {
            var commands = Regex.Matches(input,  @"([a-z][1-9]*)").Select(m => m.Value);
            foreach (var command in commands)
            {
                var turn = command[0];
                if (turn == 'l')
                {
                    dirIndex -= 1;
                }
                else if (turn == 'r')
                {
                    dirIndex++;
                }

                dirIndex = dirIndex % directions.Length;

                if (command.Length == 1) continue;

                var increment = int.Parse(command.Substring(1, command.Length -1)) - 1;

                var currentDirection = directions[dirIndex]; 
                if (currentDirection == 'N')
                {
                    currentPosition.Y += increment;
                } else if (currentDirection == 'E')
                {
                    currentPosition.X += increment;
                } else if (currentDirection == 'S')
                {
                    currentPosition.Y -= increment;
                } else if (currentDirection == 'W')
                {
                    currentPosition.X -= increment;
                }
            }

            return currentPosition;
        }
    }
}
