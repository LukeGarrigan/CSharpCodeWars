namespace CSharpCodeWars.Kyu6.PairOfGloves
{
    public class PairOfGloves
    {
        public int NumberOfPairs(string[] gloves)
        {

            var count = 0;
            var seen = new List<string>();
            for (var i = gloves.Length - 1; i >= 0; i--)
            {
                var currentGlove = gloves[i];
                if (!seen.Contains(currentGlove))
                {
                    var allGlovesOfSaidColour = gloves.Where(e => e == currentGlove);
                    count += (int) Decimal.Floor(allGlovesOfSaidColour.Count() / 2);
                    seen.Add(currentGlove);    
                }
            }
            return count;
        }
    }
}
