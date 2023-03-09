using System;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharpCodeWars.Kyu6.DecipherThis;

public class DecipherThis
{
    public string Decipher(string input)
    {
        var arr = input.Split(" ");
        for (var i = 0; i < arr.Length; i++)
        {
            var word = new StringBuilder(arr[i]);

            if (word.Length >= 1)
            {
                var value = Regex.Match(word.ToString(), @"([0-9]+)").Value;
                var asCode = Convert.ToChar(int.Parse(value));
                word.Remove(0, value.Length);
                word.Insert(0, asCode.ToString());
            }
            
            if (word.Length > 1)
            {
                var last = word[^1];
                word[^1] = word[1];
                word[1] = last;
            }

            arr[i] = word.ToString();
        }

        return string.Join(" ", arr);
    }
}
