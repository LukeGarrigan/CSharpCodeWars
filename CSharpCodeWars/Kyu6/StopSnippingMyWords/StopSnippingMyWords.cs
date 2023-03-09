using System;

namespace CSharpCodeWars.Kyu6.StopSnippingMyWords;

public class StopSnippingMyWords
{
    public string SpinWords(string sentence)
    {
        return string.Join(" ", sentence.Split(" ").Select(word => word.Length >= 5 ? string.Join("", word.Reverse()) : word));
    }
}
