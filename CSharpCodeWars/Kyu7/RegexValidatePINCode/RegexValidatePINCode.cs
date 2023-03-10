using System;
using System.Text.RegularExpressions;

namespace CSharpCodeWars.Kyu7.RegexValidatePINCode;

public class RegexValidatePINCode
{
    public bool ValidatePin(string pin)
    {
        return Regex.IsMatch(pin, "^([0-9]{4}|[0-9]{6})\\z");
    }
}
