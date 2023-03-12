using System;

namespace CSharpCodeWars.Kyu8.TotalAmountOfPoints;

public class TotalAmountOfPoints
{
    public int TotalPoints(string[] games)
    {
        // return games.Sum(s => s[0] == s[2] ? 1 : s[0] > s[2] ? 3 : 0);
        return games.Sum(game => {
            var score = int.Parse(game.Split(":")[0]);
            var opponentScore = int.Parse(game.Split(":")[1]);
            if (score == opponentScore) return 1;
            return score > opponentScore ? 3 : 0;
        });
    }
}
