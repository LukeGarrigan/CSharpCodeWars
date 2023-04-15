using System;

namespace CSharpCodeWars.Kyu7.SummingANumbersDigits;

public class SummingANumbersDigits
{
    public int SumDigits(int number) => number.ToString().Where(n => n != '-').Select(n => int.Parse(n.ToString())).Sum();
}
