using System;

namespace CSharpCodeWars.Kyu5.RGBToHexConversion;

public class RGBToHexConversion
{
    public string RgbToHex(int r,int g, int b)
    {
        if (r < 0) r = 0;
        if (r > 255) r = 255;
        if (g < 0) g = 0;
        if (g > 255) g = 255;
        if (b < 0) b = 0;
        if (b > 255) b = 255;

        var rHex = r.ToString("x"); // could have used x2 here and I wouldn't have had to pad
        var gHex = g.ToString("x");
        var bHex = b.ToString("x");

        rHex = Pad(rHex); 
        gHex = Pad(gHex);
        bHex = Pad(bHex);
        return $"{rHex}{gHex}{bHex}".ToUpper();
    }

    private static string Pad(string hex)
    {
        if (hex.Length == 1)
        {
            hex = $"0{hex}";
        }

        return hex;
    }
}
