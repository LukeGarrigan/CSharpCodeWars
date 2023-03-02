using System;
namespace CSharpCodeWars.Kyu6.AlphabetPosition
{
    public class AlphabetPosition
    {
        private static string Alphabet = "abcdefghijklmnopqrstuvwxyz";
        
        public string GetAlphabetPosition(string text)
        {
            return string.Join(" ", text.ToLower()
                .Where(c => char.IsLetter(c))
                .Select(c => Alphabet.IndexOf(c) + 1));
        }
    }
}
