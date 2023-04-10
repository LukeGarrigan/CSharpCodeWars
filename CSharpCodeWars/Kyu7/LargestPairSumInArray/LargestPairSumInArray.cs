using System;

namespace CSharpCodeWars.Kyu7.LargestPairSumInArray;

public class LargestPairSumInArray
{
    public int LargestPairSum(int[] numbers) => numbers.OrderByDescending(x => x).Take(2).Sum();
}
