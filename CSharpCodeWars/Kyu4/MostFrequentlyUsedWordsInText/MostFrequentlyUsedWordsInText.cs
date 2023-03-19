using System;
using System.Text.RegularExpressions;

namespace CSharpCodeWars.Kyu4.MostFrequentlyUsedWordsInText;

public class MostFrequentlyUsedWordsInText
{
    private static readonly string AllowedChars = "abcdefghijklmnopqrstuvwxyz'";

    public List<string> Top3(string s)
    {
        return
            Regex.Replace(s.ToLower(), @"[^a-z']", " ")
                .Split(" ")
                .Select(w => w.All(c => c == '\'') ? "" : w)
                .Where(w => !string.IsNullOrEmpty(w))
                .GroupBy(w => w)
                .OrderByDescending(w => w.Count()).ThenBy(w => w.Key)
                .Select(p => p.Key)
                .Take(3)
                .ToList();
    }
}