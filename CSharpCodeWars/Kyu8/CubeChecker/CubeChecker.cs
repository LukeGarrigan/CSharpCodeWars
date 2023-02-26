using System;
namespace CSharpCodeWars.Kyu8.CubeChecker
{
    public class CubeChecker
    {
        public bool IsCube(double volume, double side)
        {
            if (volume <= 0) return false;
            return side * side * side == volume;
        }
    }
}
