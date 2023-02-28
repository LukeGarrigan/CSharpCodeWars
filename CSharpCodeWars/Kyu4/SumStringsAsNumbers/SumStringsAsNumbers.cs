using System;
using System.Numerics;

namespace CSharpCodeWars.Kyu4.SumStringsAsNumbers
{
    public class SumStringsAsNumbers
    {
        public string SumStrings(string a, string b)
        {
            var output = "";
            var carry = 0;
            var longestLength = a.Length > b.Length ? a.Length : b.Length;
            for (var i = 0; i < longestLength; i++)
            {
                var bPos = b.Length - 1 - i;
                var aPos = a.Length - 1 - i;

                var bNum = bPos < 0 ? 0 : int.Parse(b[bPos].ToString());
                var aNum = aPos < 0 ? 0 : int.Parse(a[aPos].ToString());

                var sum = aNum + bNum + carry;
                if (sum > 9)
                {
                    carry = sum / 10;
                    var remainder = sum % 10;
                    output = remainder + output;
                }
                else
                {
                    if (sum > 0 || i != longestLength - 1)
                    {
                        output = sum + output;
                    }

                    carry = 0;
                }
            }

            if (carry > 0)
            {
                output = carry + output;
            }

            return output;
        }
    }
}