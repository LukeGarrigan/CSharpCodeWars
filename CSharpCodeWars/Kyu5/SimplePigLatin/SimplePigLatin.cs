using System;

namespace CSharpCodeWars.Kyu5.SimplePigLatin;

public class SimplePigLatin
{
    public string PigIt(string str)
    {
        return string.Join(" ", str.Split().Select(w => w.Length == 1 && !char.IsLetter(w[0]) ? w : w.Substring(1, w.Length - 1) + w[0] + "ay"));
    }
}