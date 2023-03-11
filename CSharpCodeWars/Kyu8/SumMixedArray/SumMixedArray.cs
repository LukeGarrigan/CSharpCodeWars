using System;

namespace CSharpCodeWars.Kyu8.SumMixedArray;

public class SumMixedArray
{
    public int SumMix(object[] x) => x.Sum(Convert.ToInt32);
}
