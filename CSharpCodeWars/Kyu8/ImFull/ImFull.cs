using System;

namespace CSharpCodeWars.Kyu8.ImFull;

public class ImFull
{
    public static int[] MoveFood(int[] food) => food.Where(f => f == 1).Concat(food.Where(f => f == 0)).ToArray();
}
