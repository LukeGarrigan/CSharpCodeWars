using System;
using System.Text.RegularExpressions;

namespace CSharpCodeWars.Kyu4.StripComments;

public class StripComments
{
    public string Strip(string text, string[] commentSymbols)
    {
        var lines = text.Split("\n");
        for (var index = 0; index < lines.Length; index++)
        {
            foreach (var comment in commentSymbols)
            {
                lines[index] = Regex.Replace(lines[index], $@"({Regex.Escape(comment)}.*)|\s+(?=\n)", "").TrimEnd();
            }
        }

        return string.Join("\n", lines);
    }
}
