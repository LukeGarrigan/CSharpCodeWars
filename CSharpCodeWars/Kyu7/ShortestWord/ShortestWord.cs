using System;

namespace CSharpCodeWars.Kyu7.ShortestWord;

public class ShortestWord
{
    public int FindShort(string s)
    {
        return s.Split(" ").Min(x => x.Length);
    }
}
