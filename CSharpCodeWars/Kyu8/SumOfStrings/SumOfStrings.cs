using System;

namespace CSharpCodeWars.Kyu8.SumOfStrings;

public class SumOfStrings
{
    public string StringSums(string s1, string s2)
    {
        int.TryParse(s1, out var s1AsInt);
        int.TryParse(s2, out var s2AsInt);
        return (s1AsInt + s2AsInt).ToString();
    }
}
