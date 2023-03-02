using System;
namespace CSharpCodeWars.Kyu6.BitCounting
{
    public class BitCounting
    {
        public int CountBits(int n)
        {
            return Convert.ToString(n, 2).Count(e => e == '1');
        }
    }
}
