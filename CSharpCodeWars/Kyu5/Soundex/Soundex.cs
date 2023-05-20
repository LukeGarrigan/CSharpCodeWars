using System;
using System.Text.RegularExpressions;

namespace CSharpCodeWars.Kyu5.Soundex;

public class Soundex
{
    public string CreateSoundex(string namesAsStr)
    {
        var names = namesAsStr.Split(" ");


        var exclude = new char[]
        {
            'a', 'e', 'i', 'o', 'u', 'y'
        };

        var initialExclude = new char[]
        {
            'h', 'w'
        };

        var output = new List<string>();
        
        foreach (var name in names)
        {
            var firstLetter = name[0];
            var newName = (firstLetter + string.Concat(name.Substring(1).Where(c => !initialExclude.Contains(c)))).ToLower();
            newName = Regex.Replace(newName, "[bfpv]", "1");
            newName = Regex.Replace(newName, "[cgjkqsxz]", "2");
            newName = Regex.Replace(newName, "[dt]", "3");
            newName = Regex.Replace(newName, "[l]", "4");
            newName = Regex.Replace(newName, "[mn]", "5");
            newName = Regex.Replace(newName, "[r]", "6");

            var trimmedName = name[0].ToString();
            for (var i = 1; i < newName.Length; i++)
            {
                if (!char.IsDigit(newName[i]) || !char.IsDigit(newName[i - 1]) || newName[i] != newName[i - 1])
                {
                    trimmedName += newName[i];
                }
            }

            trimmedName = trimmedName[0] + string.Concat(trimmedName.Substring(1).Where(c => !exclude.Contains(c)));

            if (char.IsDigit(trimmedName[0]))
            {
                trimmedName = firstLetter + trimmedName.Substring(1);
            }

            if (trimmedName.Count(c => char.IsDigit(c)) < 3)
            {
                trimmedName += "000";
            }

            if (trimmedName.Length > 3)
            {
                trimmedName = trimmedName.Substring(0, 4);
            }


            output.Add(trimmedName);
        }


        output = output.Select(w => w[0].ToString().ToUpper() + w.Substring(1)).ToList();
        return string.Join(" ", output);
    }
}
