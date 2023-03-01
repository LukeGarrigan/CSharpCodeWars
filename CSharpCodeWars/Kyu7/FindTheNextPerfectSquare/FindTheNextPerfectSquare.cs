using System;
namespace CSharpCodeWars.Kyu7.FindTheNextPerfectSquare
{
    public class FindTheNextPerfectSquare
    {
        public long FindNextSquare(long sq)
        {
            var r = (long)Math.Sqrt(sq);
            if (r * r != sq) return -1;
            return ((r + 1) * (r + 1));
        }
    }
}
