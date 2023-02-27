using System;
namespace CSharpCodeWars.Kyu7.FixStringCase
{
    public class FixStringCase
    {
        public string Solve(string s)
        {
            return s.Count(char.IsLower) >= s.Length / 2 ? s.ToLower() : s.ToUpper();
        }
    }
}
