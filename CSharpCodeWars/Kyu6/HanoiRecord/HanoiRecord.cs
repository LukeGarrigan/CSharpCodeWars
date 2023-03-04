using System;
namespace CSharpCodeWars.Kyu6.HanoiRecord
{
    public class HanoiRecord
    {
        public int Hanoi(int disks)
        {
            if (disks == 0) return 0;
            // 1 tile =  1
            // 2 tiles = 3
            // 3 tiles = 7
            // 4 tiles = 15
            // 5 tiles = 31
            // 6 tiles = 63
            var start = 1;
            for (var i = 1; i < disks; i++)
            {
                start = start * 2 + 1;
            }

            return start;
            
            // better solution, I just bruteforced cuz I'm lazy
            // return Math.Pow(2, disks) -1; 
        }
    }
}
