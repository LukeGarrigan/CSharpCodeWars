using System;

namespace CSharpCodeWars.Kyu7.ValidParentheses;

public class ValidParentheses
{
    public bool Valid(string str)
    {
        if (str.Length % 2 == 1) return false;

        var open = str.Length / 2;
        var closed = str.Length / 2;
        foreach (var bracket in str)
        {
            if (bracket == '(')
            {
                open--;
            }

            if (bracket == ')')
            {
                closed--;
                if (closed < open)
                {
                    return false;
                }

            }
        }
        return open == 0 && closed == 0;
    }
}
