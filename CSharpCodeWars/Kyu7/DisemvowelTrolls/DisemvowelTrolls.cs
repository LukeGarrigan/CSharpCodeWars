using System.Text.RegularExpressions;

namespace CSharpCodeWars.Kyu7.DisemvowelTrolls
{
    public class DisemvowelTrolls
    {
        public string Disemvowel(string str)
        {
            return Regex.Replace(str, "[aeiou]", "", RegexOptions.IgnoreCase);
        }
    }
}
