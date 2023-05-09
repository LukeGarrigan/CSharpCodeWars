using System;

namespace CSharpCodeWars.Kyu6.TitleCase;

public class TitleCase
{
    public string ToTitleCase(string title, string minorWords = "")
    {
        if (string.IsNullOrEmpty(title)) return "";
        
        return string.Join(" ", title.ToUpper().Split(" ").Select((word, index) => index == 0 || (minorWords == null || !minorWords.ToUpper().Split(" ").Contains(word))
            ? char.ToUpper(word.First()) + word.Substring(1, word.Length - 1).ToLower()
            : word.ToLower()));
    }
}
