using System;

namespace CSharpCodeWars.Kyu6.DoesMyNumberLookBigInThis;

public class DoesMyNumberLookBigInThis
{
    public bool Narcissistic(int value) => Enumerable.Range(1, 10).Any(power => value.ToString().ToCharArray().Select(n => Math.Pow(char.GetNumericValue(n), power)).Sum() == value);
        //
        // for (var currentPower = 1; currentPower <= 10; currentPower++)
        // {
        //     var total = 0.0;
        //
        //     foreach (var number in numbers)
        //     {
        //         total += Math.Pow(char.GetNumericValue(number), currentPower);
        //         if (total > value) break;
        //     }
        //
        //     if (total == value) return true;
        // }

        // return false;
}