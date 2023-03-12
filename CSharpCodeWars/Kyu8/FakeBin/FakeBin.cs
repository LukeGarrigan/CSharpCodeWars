using System;

namespace CSharpCodeWars.Kyu8.FakeBin;

public class FakeBin
{
    public string ToFakeBin(string x)
    {
        return string.Concat(x.ToCharArray().Select(n => n < '5' ? '0' : '1'));
        // return string.Concat(x.ToCharArray().Select(n => char.GetNumericValue(n) < 5 ? 0 : 1));
    }
}
