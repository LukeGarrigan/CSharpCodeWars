using System;

namespace CSharpCodeWars.Kyu5.RGBToHexConversion;

public class RGBToHexConversion
{
    public string RgbToHex(int r,int g, int b)
    {
        var rHex = Math.Max(Math.Min(r, 255), 0).ToString("x2");
        var gHex = Math.Max(Math.Min(g, 255), 0).ToString("x2");
        var bHex = Math.Max(Math.Min(b, 255), 0).ToString("x2");
        return $"{rHex}{gHex}{bHex}".ToUpper();
    }
}
