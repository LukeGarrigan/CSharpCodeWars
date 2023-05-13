using System;

namespace CSharpCodeWars.Kyu7.FindTheCapitals;

public class FindTheCapitals
{
    public int[] Capitals(string word) => word.Select((letter, index) => char.IsUpper(letter) ? index : -1)
        .Where(index => index != -1).ToArray();
}
