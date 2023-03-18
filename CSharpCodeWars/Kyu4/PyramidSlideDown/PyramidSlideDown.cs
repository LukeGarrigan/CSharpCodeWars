using System;
using System.Drawing;

namespace CSharpCodeWars.Kyu4.PyramidSlideDown;

public class PyramidSlideDown
{
    public int LongestSlideDown(int[][] pyramid)
    {
        var costs = new int[pyramid.Length][];
        for (var i = 0; i < pyramid.Length; i++)
        {
            costs[i] = new int[pyramid[i].Length];
            for (var j = 0; j < pyramid[i].Length; j++)
            {
                costs[i][j] = pyramid[i][j];
            }
        }

        var open = new PriorityQueue<Point, int>(Comparer<int>.Create((a, b) => b - a));
        var bottom = pyramid.GetLength(0) - 1;
        var startPos = new Point(0, 0);
        open.Enqueue(startPos, pyramid[0][0]);

        while (open.TryDequeue(out var current, out var priority))
        {
            foreach (var child in GetNeighbours(current, bottom))
            {
                var childCost = priority + pyramid[child.Y][child.X];
                if (childCost > costs[child.Y][child.X])
                {
                    costs[child.Y][child.X] = childCost;
                    open.Enqueue(child, childCost);
                }
            }
        }

        return costs[bottom].Max();
    }

    private static IEnumerable<Point> GetNeighbours(Point current, int size)
    {
        var possibleMoves = new HashSet<Point>();
        var newY = current.Y + 1;

        if (newY > size) return Array.Empty<Point>();
        
        possibleMoves.Add(new Point(current.X + 1, newY));
        possibleMoves.Add(new Point(current.X, newY));

        return possibleMoves;
    }
}