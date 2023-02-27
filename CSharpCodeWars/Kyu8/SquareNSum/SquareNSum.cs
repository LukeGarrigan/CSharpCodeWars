using System;
namespace CSharpCodeWars.Kyu8.SquareNSum
{
    public class SquareNSum
    {
        public int SquareSum(int[] numbers)
        {
            return numbers.Sum(n => n * n);
        }
    }
}
