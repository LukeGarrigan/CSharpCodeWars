using System;
using System.Text.RegularExpressions;

namespace CSharpCodeWars.Kyu5.Soundex;

public class Soundex
{
    private const string Consonants = "bcdfghjklmnpqrstvwxyz";
    public string CreateSoundex(string namesAsStr)
    {
        var names = namesAsStr.Split(" ");


        var exclude = new char[]
        {
            'h', 'w', 'a', 'e', 'i', 'o', 'u'
        };

        var output = new List<string>();
        foreach (var name in names)
        {

            var firstLetter = name[0];

            var newName = firstLetter + string.Concat(name.Substring(1).Where(c => !exclude.Contains(c)));
            newName = Regex.Replace(newName, "[bfpv]", "1");
            newName = Regex.Replace(newName, "[cgjkqsxz]", "2");
            newName = Regex.Replace(newName, "[dt]", "3");
            newName = Regex.Replace(newName, "[l]", "4");
            newName = Regex.Replace(newName, "[mn]", "5");
            newName = Regex.Replace(newName, "[r]", "6");


            var strippedName = newName[0].ToString();
            for (var i = 1; i < newName.Length; i++)
            {
                if (newName[i] != newName[i - 1])
                {
                    strippedName += newName[i];
                }

            }

            if (strippedName.Length < 4)
            {
                strippedName += "000";
                strippedName = strippedName.Substring(0, 4);
            }

            output.Add(strippedName);
        }

        return string.Join(" ", output);
    }
}
