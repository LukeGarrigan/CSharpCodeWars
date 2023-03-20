using System;

namespace CSharpCodeWars.Kyu4.AllBalancedParentheses;

public class AllBalancedParentheses
{
    public List<string> BalancedParens(int n)
    {
        var balanced = new List<string>();
        Balance(balanced, n, n, "");
        return balanced;
    }

    private void Balance(List<string> balanced, int openingBrackets, int closingBrackets, string current)
    {
        if (openingBrackets == 0 && closingBrackets == 0)
        {
            balanced.Add(current);
            return;
        }

        if (openingBrackets > 0)
        {
            Balance(balanced, openingBrackets - 1, closingBrackets, current + "(");
        }

        if (openingBrackets < closingBrackets)
        {
            Balance(balanced, openingBrackets, closingBrackets - 1, current + ")");
        }
    }
}
