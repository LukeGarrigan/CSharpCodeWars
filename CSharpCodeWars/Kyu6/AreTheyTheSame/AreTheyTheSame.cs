using System;

namespace CSharpCodeWars.Kyu6.AreTheyTheSame;

public class AreTheyTheSame
{
    public bool Comp(int[] arr1, int[] arr2)
    {
        return arr1
            .OrderBy(n => n)
            .SequenceEqual(arr2.Select(n => (int)Math.Sqrt(n))
            .OrderBy(e => e));
    }
}
