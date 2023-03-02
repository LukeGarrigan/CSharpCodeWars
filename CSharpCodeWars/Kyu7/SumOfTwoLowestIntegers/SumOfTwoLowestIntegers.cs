using System;
namespace CSharpCodeWars.Kyu7.SumOfTwoLowestIntegers
{
    public class SumOfTwoLowestIntegers
    {
        public int SumTwoSmallestNumbers(int[] numbers)
        {
            // Array.Sort(numbers);
            // return numbers[0] + numbers[1];

            return numbers.OrderBy(i => i).Take(2).Sum();
        }
    }
}
