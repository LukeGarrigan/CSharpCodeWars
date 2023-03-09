using System;

namespace CSharpCodeWars.Kyu6.MultiplesOf3or5;

public class MultiplesOf3or5
{
    public int Solution(int value)
    {
        // var sum = 0;
        // for (var i = 0; i < value; i++)
        // {
        //     if (i % 3 == 0 || i % 5 == 0)
        //     {
        //         sum += i;
        //     }
        // }
        // return sum;
        return Enumerable.Range(0, value).Where((i) => i % 3 == 0 || i % 5 == 0).Sum();
    }
}
