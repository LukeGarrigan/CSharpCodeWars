using System;
namespace CSharpCodeWars.Kyu6.YourOrderPlease
{
    public class YourOrderPlease
    {
        public string Order(string words)
        {
            return string.Join(" ", words.Split().OrderBy(w => w.SingleOrDefault(char.IsDigit)));
        }
    }
}
