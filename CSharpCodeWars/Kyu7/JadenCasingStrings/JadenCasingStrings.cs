using System;
using System.Globalization;

namespace CSharpCodeWars.Kyu7.JadenCasingStrings;

public static class JadenCasingStrings
{
    public static string ToJadenCase(this string phrase)
    {
        return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(phrase);

        // return string.Join(" ", phrase.Split(" ").Select(word => char.ToUpper(word[0]) + word.Substring(1)));    
    }

    
}
