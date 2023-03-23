using System;

namespace CSharpCodeWars.Kyu4.HammingNumbers;

public class HammingNumbers
{
    public long Hamming(int n)
    {
        var numbers = new List<long>();
        var highestPower = 10;
        for (var i = 0; i < highestPower; i++)
        {
            for (int j = 0; j < highestPower; j++)
            {
                for (int k = 0; k < highestPower; k++)
                {
                    numbers.Add((long)(Math.Pow(2, i) * Math.Pow(3, j) * Math.Pow(5, k)));
                }
            }
        }

        return numbers.Where(n => n > 0).OrderBy(e => e).ElementAt(n - 1);
    }
}
