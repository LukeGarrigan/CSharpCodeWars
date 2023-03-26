using System;
using System.Drawing;
using System.Reflection;
using System.Runtime.InteropServices;
using NUnit.Framework;

namespace CSharpCodeWars.Kyu3.BattleshipFieldValidator;

public class BattleshipFieldValidator
{
    public bool ValidateBattleField(int[,] field)
    {
        if (field.GetLength(0) != 10 && field.GetLength(1) != 10) return false;
        var availableShips = new List<int>()
        {
            4, 3, 3, 2, 2, 2, 1, 1, 1, 1
        };

        var seen = new HashSet<Point>();
        

        for (int x = 0; x < 10; x++)
        {
            for (int y = 0; y < 10; y++)
            {
                if (!seen.Contains(new Point(x, y)) && field[x, y] == 1)
                {
                    var count = 1;
                    seen.Add(new Point(x, y));
                    var directions = GetDirectionsForCell(field, x, y, seen);
                    if (directions == null)
                    {
                        return false;
                    }

                    while (directions.Any())
                    {
                        var dir = directions.Pop();

                        if (dir == Directions.LEFT)
                        {

                            for (var i = 1; i <= 3; i++)
                            {
                                var leftDirs = GetDirectionsForCell(field, x - i, y, seen);
                                if (leftDirs == null || leftDirs.Any(dir => dir is Directions.UP or Directions.DOWN))
                                {
                                    return false;
                                }
                                seen.Add(new Point(x - i, y));
                                count++;
                                if (!leftDirs.Contains(Directions.LEFT))
                                {
                                    break;
                                }
                            }
                        }
                    
                        if (dir == Directions.RIGHT)
                        {
                            for (var i = 1; i <= 3; i++)
                            {
                                var rightDirs = GetDirectionsForCell(field, x + i, y, seen);
                                if (rightDirs == null || rightDirs.Any(dir => dir is Directions.UP or Directions.DOWN))
                                {
                                    return false;
                                }
                                seen.Add(new Point(x + i, y));
                                count++;
                                if (!rightDirs.Contains(Directions.RIGHT))
                                {
                                    break;
                                }
                            }
                        }
                        
                        if (dir == Directions.UP)
                        {
                            for (var i = 1; i <= 3; i++)
                            {
                                var upDirs = GetDirectionsForCell(field, x, y - i, seen);
                                if (upDirs == null || upDirs.Any(dir => dir is Directions.LEFT or Directions.RIGHT))
                                {
                                    return false;
                                }
                                seen.Add(new Point(x, y - i));
                                count++;
                                if (!upDirs.Contains(Directions.UP))
                                {
                                    break;
                                }
                            }
                        }
                        
                        if (dir == Directions.DOWN)
                        {
                            for (var i = 1; i <= 3; i++)
                            {
                                var downDirs = GetDirectionsForCell(field, x, y + i, seen);
                                if (downDirs == null || downDirs.Any(dir => dir is Directions.LEFT or Directions.RIGHT))
                                {
                                    return false;
                                }
                                seen.Add(new Point(x, y + i));
                                count++;
                                if (!downDirs.Contains(Directions.DOWN))
                                {
                                    break;
                                }
                            }
                        }
                    }

                    if (!availableShips.Contains(count))
                    {
                        return false;
                    }
                    availableShips.Remove(count);
                }
            }
        }

        return !availableShips.Any();
    }

    private static Stack<Directions>? GetDirectionsForCell(int[,] field, int x, int y, HashSet<Point> seen)
    {
        var validDirections = new Stack<Directions>();
        var right = x < 9 && !seen.Contains(new Point(x + 1, y )) && field[x + 1, y] == 1;
        if (right) validDirections.Push(Directions.RIGHT);

        var left = x != 0 && !seen.Contains(new Point(x - 1, y )) && field[x - 1, y] == 1;
        if (left) validDirections.Push(Directions.LEFT);

        var up = y != 0 && !seen.Contains(new Point(x, y - 1)) && field[x, y - 1] == 1;
        if (up) validDirections.Push(Directions.UP);

        var down = y < 9 && !seen.Contains(new Point(x, y + 1)) && field[x, y + 1] == 1;
        if (down) validDirections.Push(Directions.DOWN);

        if (x > 0 && y > 0 && field[x - 1, y - 1] == 1) return null;
        if (x < 9 && y < 9 && field[x + 1, y + 1] == 1) return null;
        if (x < 9 && y > 0 && field[x + 1, y - 1] == 1) return null;
        if (y < 9 && x > 0 && field[x - 1, y + 1] == 1) return null;


        if (validDirections.Count == 2)
        {
            if (!(right && left || up && down))
            {
                return null;
            }
        }

        return validDirections;
    }
    
    enum Directions
    {
        LEFT,
        RIGHT,
        UP,
        DOWN
    }
}

