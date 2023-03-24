using System;
using System.Runtime.InteropServices;
using System.Text;

namespace CSharpCodeWars.Kyu4.MiddlePermutation;

public class MiddlePermutation
{
    public string GetMiddlePermutation(string s)
    {
        var permutations = new List<string>();
        Permute(s, 0, s.Length - 1, permutations);
        var ordered = permutations.OrderBy(p => p);
        return ordered.Count() % 2 == 0 ? ordered.ElementAt(ordered.Count() / 2 - 1) : ordered.ElementAt(ordered.Count() / 2);
    }

    private void Permute(string s, int startIndex, int endIndex, List<string> permutations)
    {
        if (startIndex == endIndex)
        {
            permutations.Add(s);
        }

        for (var i = startIndex; i <= endIndex; i++)
        {
            var sb = new StringBuilder(s);
            (sb[startIndex], sb[i]) = (sb[i], sb[startIndex]);
            Permute(sb.ToString(), startIndex + 1, endIndex, permutations);
        }
    }
}
