using System;

namespace CSharpCodeWars.Kyu4.NextSmallerNumberWithSameDigits;

public class NextSmallerNumberWithSameDigits
{
    public long NextSmaller(long n)
    {
        var numbers = n.ToString().ToCharArray().Select(n => (int)char.GetNumericValue(n)).ToList();

        var smallest = numbers[^1];
        var xIndex = numbers.Count - 1;
        for (var i = numbers.Count - 1; i >= 0; i--)
        {
            if (numbers[i] > smallest)
            {
                xIndex = i;
                break;
            }
            else if (numbers[i] < smallest)
            {
                smallest = numbers[i];
            }
        }

        var x = numbers[xIndex];
        var biggestBrother = -1;
        var biggestBrotherIndex = numbers.Count -1;
        for (var i = xIndex; i < numbers.Count; i++)
        {
            if (numbers[i] > biggestBrother && numbers[i] < x)
            {
                biggestBrother = numbers[i];
                biggestBrotherIndex = i;
            }
        }

        (numbers[xIndex], numbers[biggestBrotherIndex]) = (numbers[biggestBrotherIndex], numbers[xIndex]);


        var leftSide = numbers.GetRange(0, xIndex + 1);
        var rightSide = numbers.GetRange(xIndex + 1, numbers.Count - leftSide.Count).OrderByDescending(n => n);
        if (leftSide.ElementAt(0) == 0)
        {
            return -1;
        }

        var output = long.Parse(string.Concat(leftSide.Concat(rightSide)));
        if (output == n)
        {
            return -1;
        }

        return output;
    }
}