using System;
using System.Text;

namespace CSharpCodeWars.Kyu6.LongestPalindrome;

public class LongestPalindrome
{
    public int GetLongestPalindrome(string str)
    {
        if (str == null || str.Length == 0) return 0;
        var biggest = 1;
        for (int i = 0; i < str.Length - 1; i++)
        {
            var current = new StringBuilder(str[i]);
            for (int j = i; j < str.Length; j++)
            {
                current.Append(str[j]);

                if (string.Concat(current.ToString().Reverse()) == current.ToString())
                {
                    if (current.Length > biggest)
                    {
                        biggest = current.Length;
                    }
                }
            }
        }

        return biggest;
    }
}
