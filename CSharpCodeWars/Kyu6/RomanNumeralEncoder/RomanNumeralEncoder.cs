using System;
using System.Text;

namespace CSharpCodeWars.Kyu6.RomanNumeralEncoder;

public class RomanNumeralEncoder
{
    private readonly Dictionary<int, string> SymbolValue = new()
    {
        { 1, "I" },
        { 4, "IV" },
        { 5, "V" },
        { 9, "IX" },
        { 10, "X" },
        { 40, "XL" },
        { 50, "L" },
        { 90, "XC" },
        { 100, "C" },
        { 400, "CD" },
        { 500, "D" },
        { 900, "CM" },
        { 1000, "M" }
    };

    private readonly IEnumerable<int> Numbers = new[]
    {
        1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000
    };

    public string Solution(int n)
    {
        var sb = new StringBuilder();

        while (n != 0)
        {
            var biggestNumber = Numbers.Where(num => num <= n).Max();
            sb.Append(SymbolValue[biggestNumber]);
            n -= biggestNumber;
        }

        return sb.ToString();
    }
}