using System;
namespace CSharpCodeWars.Kyu7.SumListIgnoreDups
{
    public class SumListIgnoreDups
    {
        public int SumNoDuplicates(int[] arr)
        {
            return arr.Sum(e => arr.Count(value => e == value) == 1 ? e : 0);
        }
    }
}
