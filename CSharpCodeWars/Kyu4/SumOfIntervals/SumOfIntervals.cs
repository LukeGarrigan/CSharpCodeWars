namespace CSharpCodeWars.Kyu4.SumOfIntervals
{
    public class SumOfIntervals
    {
        public int SumIntervals((int arg1, int)[] intervals)
        {
            var total = 0;

            var adjustedIntervals = AdjustIntervals(intervals);
            
            foreach (var (start, end) in adjustedIntervals)
            {
                total += end - start;

            }
            return total;
        }

        private (int start, int end)[] AdjustIntervals((int start, int end)[] intervals)
        {
            var newIntervals = new Dictionary<int, int>();

            foreach (var (start, end) in intervals)
            {

                var overlapping = newIntervals.Where((KeyValuePair) =>
                    start > KeyValuePair.Key && start < KeyValuePair.Value ||
                    end > KeyValuePair.Key && end < KeyValuePair.Value || 
                    KeyValuePair.Key > start && KeyValuePair.Value <= end);

                var highest = end;
                var lowest = start;
                
                foreach (var keyValuePair in overlapping)
                {
                    if (keyValuePair.Key <= lowest)
                    {
                        lowest = keyValuePair.Key;
                    }

                    if (keyValuePair.Value >= highest)
                    {
                        highest = keyValuePair.Value;
                    }
                }
                
                foreach (var keyValuePair in overlapping)
                {
                    newIntervals.Remove(keyValuePair.Key);
                }

                newIntervals.Remove(lowest);
                newIntervals.Add(lowest, highest);
                // start is between (5-10, 6-11)    = 5-11
                // end is between (5-10, 3-6)       = 3-10
                // both between (5-10, 6-9)         = 5-10
                // existing is between (5-10, 4-12) = 4-12
                // 5 10
                // 4 8
            }

            return newIntervals.Select(kvp => (kvp.Key, kvp.Value)).ToArray();
        }
    }
}
