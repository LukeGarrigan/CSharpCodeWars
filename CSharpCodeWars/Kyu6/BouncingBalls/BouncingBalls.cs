using System;
namespace CSharpCodeWars.Kyu6.BouncingBalls
{
    public class BouncingBalls
    {
        public int BouncingBall(double h, double bounce, double window)
        {
            if(h <= 0 || bounce <= 0 || bounce >= 1 || window >= h) return -1;
            // h = 100m
            // bounce = 0.5
            // window = 5
            
            // 100 
            // 50
            // 25
            // 12.5
            // 6.75
            // 3.375
            
            var count = 0;
            while (h > window)
            {
                h *= bounce;
                count+=2;
            }

            count--;
            return count;
        }
    }
}
