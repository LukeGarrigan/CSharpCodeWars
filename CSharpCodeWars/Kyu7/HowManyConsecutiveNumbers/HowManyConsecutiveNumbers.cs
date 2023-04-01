using System;

namespace CSharpCodeWars.Kyu7.HowManyConsecutiveNumbers;

public class HowManyConsecutiveNumbers
{
    
    public int Consecutive(int[] arr) => arr.Any() ? arr.Max() - arr.Min() + 1 - arr.Length : 0;

        // if (!arr.Any()) return 0;
        // arr = arr.OrderBy(e => e).ToArray();
        // var total = 0;
        // var previous = arr[0];
        // for (var i = 1; i < arr.Length; i++)
        // {
        //     if (arr[i] != previous + 1)
        //     {
        //         total +=  arr[i] - (previous + 1);
        //     }
        //     previous = arr[i];
        // }
        // return total;
}
