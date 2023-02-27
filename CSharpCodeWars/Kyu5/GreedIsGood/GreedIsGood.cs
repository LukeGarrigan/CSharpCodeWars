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
            var dictionary = new Dictionary<int, int>();

            foreach (var current in dice)
            {
                if (dictionary.ContainsKey(current))
                {
                    dictionary[current]++;
                }
                else
                {
                    dictionary[current] = 1;
                }
            }

            var total = 0;
            foreach (var (key, value) in dictionary)
            {
                if (key == 1 && value < 3)
                {
                    total += key * 100 * value;
                }

                if (key == 5 && value < 3)
                {
                    total += key * 10 * value;
                }

                if (value >= 3)
                {
                    total += key * (key == 1 ? 1000 : 100);

                    if (value - 3 >= 1)
                    {
                        if (key == 5)
                        {
                            total += 50 * (value - 3);
                        }
                        if (key == 1)
                        {
                            total += 100 * (value - 3);
                        }
                    }
                }

            }

            return total;
        }
    }
}
