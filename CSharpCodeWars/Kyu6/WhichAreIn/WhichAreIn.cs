using System;

namespace CSharpCodeWars.Kyu6.WhichAreIn;

public class WhichAreIn
{
    public string[] InArray(string[] arr1, string[] arr2) => arr1.Where(word => arr2.Any(w => w.Contains(word))).OrderBy(e => e).ToArray();
}
