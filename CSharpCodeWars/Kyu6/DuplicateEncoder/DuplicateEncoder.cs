using System;
namespace CSharpCodeWars.Kyu6.DuplicateEncoder
{
    public class DuplicateEncoder
    {
        public string DuplicateEncode(string word)
        {
            return string.Join("", word.ToLower().Select(c => word.ToLower().Count(ch => ch == c) == 1 ? '(' : ')'));
        }
    }
}
