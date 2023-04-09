using System;
using System.Text;

namespace CSharpCodeWars.Kyu6.GiveMeADiamond;

public class GiveMeADiamond
{
    public string Print(int length)
    {
        if (length < 0 || length % 2 == 0) return null;
        var space = string.Concat(Enumerable.Repeat(" ", (length - 1) / 2));

        var sb = new StringBuilder();
        for (var i = 0; i < length / 2; i++)
        {
            sb.Append(space + string.Concat(Enumerable.Repeat("*", i * 2+ 1)) + "\n");
            space = space.Substring(1, space.Length -1);
        }

        sb.Append(string.Concat(Enumerable.Repeat("*", length)) + "\n");
        var count = length - 2;
        space = " ";
        for (var i = 0; i < length / 2; i++)
        {
            sb.Append(space + string.Concat(Enumerable.Repeat("*", count)) + "\n");
            space = space + " ";
            count-=2;
        }
        return sb.ToString();
    }
}
