using System;
using System.Collections.Immutable;

namespace CSharpCodeWars.Kyu6.SortTheOdd
{
    public class SortTheOdd
    {
        public int[] SortArray(int[] array)
        {
            var oddNumbers = array.Where(n => n % 2 == 1).OrderBy(i => i).ToList();

            var currentIndex = 0;
            for (var i = 0; i < oddNumbers.Count(); i++)
            {
                while (array[currentIndex] % 2 != 1)
                {
                    currentIndex++;
                }
                array[currentIndex] = oddNumbers[i];
                currentIndex++;
            }

            return array;
        }
    }
}
