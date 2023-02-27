using System;
namespace CSharpCodeWars.Kyu5.GreedIsGood
{
    public class GreedIsGood
    {
        
        // Three 1's => 1000 points
        // Three 6's =>  600 points
        // Three 5's =>  500 points
        // Three 4's =>  400 points
        // Three 3's =>  300 points
        // Three 2's =>  200 points
        // One   1   =>  100 points
        // One   5   =>   50 point

        public int Score(int[] dice)
        {

            int[] tripleValues = { 0, 1000, 200, 300, 400, 500, 600 };
            int[] singleValues = { 0, 100, 0, 0, 0, 50, 0 };

            var total = 0;
            for (var dieSide = 1; dieSide <= 6; dieSide++)
            {
                var valueCount = dice.Count(roll => roll == dieSide);
                total += tripleValues[dieSide] * (valueCount / 3) + (valueCount % 3) * singleValues[dieSide];
            }

            return total;
        }
    }
}
