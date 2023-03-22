using System;

namespace CSharpCodeWars.Kyu4.NextBiggerNumber;

public class NextBiggerNumber
{
    public long NextBigger(long n)
    {
        var numbers = n.ToString().ToCharArray().Select(n => (int)char.GetNumericValue(n)).ToList();

        var biggest = numbers[^1];
        var xIndex = numbers.Count - 1;
        for (var i = numbers.Count - 1; i >= 0; i--)
        {
            if (numbers[i] < biggest)
            {
                xIndex = i;
                break;
            }
            else if (numbers[i] > biggest)
            {
                biggest = numbers[i];
            }
        }

        var x = numbers[xIndex];
        var biggestBrother = int.MaxValue;
        var biggestBrotherIndex = numbers.Count -1;
        for (var i = xIndex; i < numbers.Count; i++)
        {
            if (numbers[i] < biggestBrother && numbers[i] > x)
            {
                biggestBrother = numbers[i];
                biggestBrotherIndex = i;
            }
        }

        (numbers[xIndex], numbers[biggestBrotherIndex]) = (numbers[biggestBrotherIndex], numbers[xIndex]);


        var leftSide = numbers.GetRange(0, xIndex + 1);
        var rightSide = numbers.GetRange(xIndex + 1, numbers.Count - leftSide.Count).OrderBy(n => n);
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
