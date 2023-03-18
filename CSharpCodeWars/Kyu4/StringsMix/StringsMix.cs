using System;

namespace CSharpCodeWars.Kyu4.StringsMix;

public class StringsMix
{
    public string Mix(string s1, string s2)
    {
        var group1 = s1.GroupBy(s => s).OrderBy(g => g.Count()).Where(g => g.Count() > 1 && char.IsLower(g.Key));
        var group2 = s2.GroupBy(s => s).OrderBy(g => g.Count()).Where(g => g.Count() > 1 && char.IsLower(g.Key));

        var outputList = new List<string>();
        
        ProcessGroup(group1, group2, 1, outputList);
        ProcessGroup(group2, group1, 2, outputList);

        var sortedList = outputList.OrderByDescending(item => item.Length).ThenBy(item => item[0]).ThenBy(item => item);
        
        return string.Join("/", sortedList);
    }

    private static void ProcessGroup(IEnumerable<IGrouping<char, char>> group1,
        IEnumerable<IGrouping<char, char>> group2, int groupNumber, List<string> outputList)
    {
        foreach (var group in group1)
        {
            var biggest = group.Count();
            var biggestGroup = groupNumber;

            if (group2.Any(g => g.Key == group.Key))
            {
                var otherGroupSize = group2.First(g => g.Key == group.Key).Count();
                if (otherGroupSize > biggest)
                {
                    biggest = otherGroupSize;
                    biggestGroup = groupNumber == 1 ? 2 : 1;
                } else if (otherGroupSize == biggest)
                {
                    biggestGroup = -1;
                }
            }

            if (!outputList.Any(e => e.EndsWith(group.Key)))
            {
                var groupForChar = biggestGroup == -1 ? "=" : biggestGroup.ToString();
                outputList.Add($"{groupForChar}:{String.Concat(Enumerable.Range(0, biggest).Select(i => group.Key))}");    
            }
        }
    }
}
