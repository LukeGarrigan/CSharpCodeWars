using System;

namespace CSharpCodeWars.Kyu4.SoManyPermutations;

public class SoManyPermutations
{
    public List<string> SinglePermutations(string s)
    {
        var permutations = new List<string>();
        Permute(s, 0, s.Length-1, permutations);
        return permutations.OrderBy(w => w).Distinct().ToList();
    }
    
    static void Permute(string str, int l, int r, List<string> permutations) {
        if (l == r)
            permutations.Add(str);
        else {
            for (int i = l; i <= r; i++) {
                str = Swap(str, l, i);
                Permute(str, l+1, r, permutations);
                str = Swap(str, l, i);
            }
        }
    }

    private static string Swap(string str, int i, int j) {
        var charArray = str.ToCharArray();
        (charArray[i], charArray[j]) = (charArray[j], charArray[i]);
        return new string(charArray);
    }
 
}
