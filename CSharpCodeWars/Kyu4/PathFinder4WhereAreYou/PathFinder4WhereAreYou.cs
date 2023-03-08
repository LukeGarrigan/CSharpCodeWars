using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace CSharpCodeWars.Kyu4.PathFinder4WhereAreYou
{
    public static class PathFinder4WhereAreYou
    {
        private static char[] directions = new char[] {'N', 'E', 'S', 'W'};
        private static int dirIndex = 3;
        private static Point currentPosition = new Point(0, 0);
        private static int count = 0;
        
        public static Point IAmHere(string input)
        {
            var commands = Regex.Matches(input,  @"([a-zA-Z])|([0-9]+)").Select(m => m.Value);

            foreach (var command in commands)
            {
                if (command.Length == 1 && char.IsLetter(command[0]))
                {
                    var turn = command[0];
                    if (turn == 'l')
                    {
                        
                        dirIndex--;
                        if (dirIndex == -1) dirIndex = directions.Length - 1;
                    }
                    else if (turn == 'r')
                    {
                        dirIndex++;
                    } else if (turn is 'L' or 'R')
                    {
                        dirIndex += 2;
                    }

                    dirIndex %= directions.Length;
                }
                else
                {
                    var increment = int.Parse(command);
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
            }

            return currentPosition;
        }
    }
}
