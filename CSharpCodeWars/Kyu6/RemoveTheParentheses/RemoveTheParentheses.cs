using System;
using System.Text.RegularExpressions;

namespace CSharpCodeWars.Kyu6.RemoveTheParentheses;

public class RemoveTheParentheses
{
    public string RemoveParentheses(string s)
    {
        var openingBracketIndexs = new List<int>();
        for (var index = 0; index < s.Length; index++)
        {
            var ch = s[index];
            if (ch == '(')
            {
                openingBracketIndexs.Add(index);
            }

            if (ch == ')' && openingBracketIndexs.Any())
            {
                s = s.Remove(openingBracketIndexs.Last(), index - openingBracketIndexs.Last() + 1);
                openingBracketIndexs = new List<int>();
                index = -1;
            }
        }

        return s;
    }
}