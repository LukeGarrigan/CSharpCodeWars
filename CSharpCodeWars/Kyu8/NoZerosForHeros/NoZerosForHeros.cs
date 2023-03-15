using System;

namespace CSharpCodeWars.Kyu8.NoZerosForHeros;

public class NoZerosForHeros
{
    public int NoBoringZeros(int n) => int.Parse(n.ToString().TrimEnd('0'));
}
