using System;
namespace CSharpCodeWars.Kyu7.AverageOfNumbers
{
    public class AverageOfNumbers
    {
        public double[] Averages(int[] numbers)
        {
            // this is interesting if you skip then the index isn't the actual arrays index
            // it's just the current iteration
            // so for this example [3, 2, 5]
            // x is 2 and i = 0 which means numbers[i] = 3
            return numbers?.Skip(1).Select((x, i) => (double)(x + numbers[i]) / 2).ToArray() ?? Array.Empty<double>();
        }
    }
}
