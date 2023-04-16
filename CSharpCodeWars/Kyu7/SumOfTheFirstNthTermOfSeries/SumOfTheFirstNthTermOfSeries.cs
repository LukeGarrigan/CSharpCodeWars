using System;

namespace CSharpCodeWars.Kyu7.SumOfTheFirstNthTermOfSeries;

public class SumOfTheFirstNthTermOfSeries
{
    public string SeriesSum(int n)
    {
        if (n == 0) return "0.00";
        if (n == 1) return "1.00";

        var value = 1.0;
        var divisor = 4;
        for (var i = 1; i < n; i++)
        {
            value += 1.0 / divisor;
            divisor += 3;
        }

        return Math.Round(value, 2).ToString("0.00");
    }
}
