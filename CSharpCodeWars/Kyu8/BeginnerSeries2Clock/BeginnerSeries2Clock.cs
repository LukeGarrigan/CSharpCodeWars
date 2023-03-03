using System;
namespace CSharpCodeWars.Kyu8.BeginnerSeries2Clock
{
    public class BeginnerSeries2Clock
    {
        public int Past(int h, int m, int s)
        {
            return (h * 60 * 60 * 1000) + (m * 60 * 1000) + (s * 1000);
        }
    }
}
