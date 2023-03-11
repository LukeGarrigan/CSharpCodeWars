using System;

namespace CSharpCodeWars.Kyu8.CountByX;

public class CountByX
{
    public int[] CountBy(int x, int n)
    {
        return Enumerable.Range(1, n).Select(i => i * x).ToArray();
    }
}
