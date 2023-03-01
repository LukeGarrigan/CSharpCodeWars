using System;
namespace CSharpCodeWars.Kyu7.FindTheNextPerfectSquare
{
    public class FindTheNextPerfectSquare
    {
        public long FindNextSquare(long perfSquare)
        {
            var sqrt = Math.Sqrt(perfSquare); 
            if (sqrt % 1 != 0) return -1;
            sqrt++;
            return Convert.ToInt64(sqrt*sqrt);
        }
    }
}
