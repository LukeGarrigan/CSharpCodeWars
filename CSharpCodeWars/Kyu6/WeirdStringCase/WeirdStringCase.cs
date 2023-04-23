using System;
using System.Text;

namespace CSharpCodeWars.Kyu6.WeirdStringCase;

public class WeirdStringCase
{
    public string ToWeirdCase(string s) => string.Join(" ", s.Split(" ").Select(w => string.Concat(w.Select((c, i) => i % 2 == 0 ? char.ToUpper(c) : char.ToLower(c)))));
        // var sb = new StringBuilder();
        // foreach (var word in words)
        // {
        //     for (var i = 0; i < word.Length; i++)
        //     {
        //         sb.Append(i % 2 == 0 ? char.ToUpper(word[i]) : char.ToLower(word[i]));
        //     }
        //
        //     sb.Append(" ");
        // }
        // return sb.ToString().Trim();
    // }
}
