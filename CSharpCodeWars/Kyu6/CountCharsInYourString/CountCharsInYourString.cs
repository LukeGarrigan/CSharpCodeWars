using System;

namespace CSharpCodeWars.Kyu6.CountCharsInYourString;

public class CountCharsInYourString
{
    public Dictionary<char, int> Count(string str) => str.GroupBy(c => c).ToDictionary(c => c.Key, c => c.Count());
}
