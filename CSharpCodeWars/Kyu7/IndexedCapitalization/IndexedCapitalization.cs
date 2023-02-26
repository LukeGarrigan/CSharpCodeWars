using System;
namespace CSharpCodeWars.Kyu7.IndexedCapitalization
{
    public class IndexedCapitalization
    {
        public string Capitalize(string s, List<int> indexes)
        {
            var output = "";
            for (var i = 0; i < s.Length; i++)
            {
                output += indexes.Contains(i) ? s[i].ToString().ToUpper() : s[i];
            }
            return output;
        }
    }
}
