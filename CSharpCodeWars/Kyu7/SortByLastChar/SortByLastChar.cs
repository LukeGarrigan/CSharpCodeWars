using System;

namespace CSharpCodeWars.Kyu7.SortByLastChar;

public class SortByLastChar
{
    public string[] Last(string x) =>  x.Split(" ").OrderBy(w => w[^1]).ToArray();
}
