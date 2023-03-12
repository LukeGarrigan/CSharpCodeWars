using System;

namespace CSharpCodeWars.Kyu7.RemoveTheMinmimum;

public class RemoveTheMinmimum
{
    public List<int> RemoveSmallest(List<int> numbers)
    {
        // somebodies solution, extremely inefficient, but was exactly what I was trying to do!
        // essentially wanted to do a where clause but only ignore the first element that didn't match the where
        return numbers.Where((n, i) => i != numbers.IndexOf(numbers.Min())).ToList();

        // if (numbers.Count == 0) return numbers;
        // var newList = new List<int>(numbers);
        // newList.Remove(numbers.MinBy(e => e));
        // return newList;
    }
}
