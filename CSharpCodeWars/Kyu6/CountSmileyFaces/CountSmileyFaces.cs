using System;
namespace CSharpCodeWars.Kyu6.CountSmileyFaces
{
    public class CountSmileyFaces
    {
        public int CountSmileys(string[] smileys)
        {
            var validSmileys = new[] { ":)", ":-)", ":~)", ";)", ";-)", ";~)", ";~D", ":D", ":-D", ":~D", ";-D", ";D" };
            return smileys.Count(smile => validSmileys.Contains(smile));
        }
    }
}
