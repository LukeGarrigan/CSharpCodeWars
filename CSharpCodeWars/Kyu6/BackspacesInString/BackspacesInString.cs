using System;
using System.Text;

namespace CSharpCodeWars.Kyu6.BackspacesInString;

public class BackspacesInString
{
    public string CleanString(string s)
    {
        var sb = new StringBuilder(s);
        while (sb.ToString().Contains("#"))
        {
            var index = sb.ToString().IndexOf('#');
            sb.Remove(index, 1);

            var last = -1;
            for (var i = 0; i < index; i++)
            {
                if (sb[i] != '#')
                {
                    last = i;
                }
            }

            if (last != -1)
            {
                sb.Remove(last, 1);
            }
        }
        return sb.ToString();
    }
}
