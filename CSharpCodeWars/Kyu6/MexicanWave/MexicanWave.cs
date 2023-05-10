using System;
using System.Text;

namespace CSharpCodeWars.Kyu6.MexicanWave;

public class MexicanWave
{
    public List<string> Wave(string str) => str
        .Select((c, i) => str.Substring(0, i) + char.ToUpper(c) + str.Substring(i + 1))
        .Where(w => w != str).ToList();


    // {
    //     var output = new List<string>();
    //     for (var i = 0; i < str.Length; i++)
    //     {
    //         var sb = new StringBuilder(str);
    //         sb[i] = char.ToUpper(str[i]);
    //
    //         if (sb[i].ToString() != " ")
    //             output.Add(sb.ToString());
    //     }
    //     return output;
    // }
}