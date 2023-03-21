using System;
using System.Diagnostics;

namespace CSharpCodeWars.Kyu6.LongestConsecutiveRepetition;

public class LongestConsecutiveRepetition
{
    public Tuple<char?, int> LongestRepetition(string input)
    {
        var current = '0';
        var currentCount = 0;
        var biggest = 0;
        var biggestChar = '0';
        for (int i = 0; i < input.Length; i++)
        {
            var currentChar = input[i];

            if (currentChar == current)
            {
                currentCount++;
            }
            else
            {
                current = currentChar;
                currentCount = 1;
            }

            if (currentCount > biggest)
            {
                biggest = currentCount;
                biggestChar = currentChar;
            }
        }

        return new Tuple<char?, int>(biggestChar == '0' ? null : biggestChar, biggest);

    }
}
