using System;

namespace CSharpCodeWars.Kyu7.TheSpiralingBox;

public class TheSpiralingBox
{
    public int[,] CreateBox(int width, int length)
    {
        var arr = new int[length, width];
        for (var x = 0; x < length; x++)
        {
            var tempX = x;
            if (x > ((length / 2) -1))
            {
                tempX = length - (tempX + 1);
            }

            for (var y = 0; y < width; y++)
            {
                var tempY = y;
                if (y > ((width / 2) -1))
                {
                    tempY = width - (tempY + 1);
                }
                
                if (tempX < tempY)
                {
                    arr[x, y] = tempX + 1;
                }
                else
                {
                    arr[x, y] = tempY + 1;
                }
            }
        }

        return arr;

    }
}
