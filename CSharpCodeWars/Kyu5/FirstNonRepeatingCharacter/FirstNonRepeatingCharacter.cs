using System;

namespace CSharpCodeWars.Kyu5.FirstNonRepeatingCharacter;

public class FirstNonRepeatingCharacter
{
    public string FirstNonRepeatingLetter(string s)
    {
        return s.GroupBy(char.ToLower)
            .Where(gr => gr.Count() == 1)
            .Select(gr => gr.First().ToString())
            .DefaultIfEmpty("")
            .First();
            

        // var dict = new Dictionary<char, int>();
        // foreach (var c in s)
        // {
        //     if (dict.ContainsKey(char.ToLower(c)))
        //     {
        //         dict[char.ToLower(c)] += 1;
        //     }
        //     else
        //     {
        //         dict[char.ToLower(c)] = 1;
        //     }
        // }
        //
        // var result = s.FirstOrDefault(c => dict[char.ToLower(c)] == 1);
        // return result == char.MinValue ? "" : result.ToString();
    }
}