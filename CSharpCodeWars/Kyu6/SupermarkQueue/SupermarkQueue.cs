using System;

namespace CSharpCodeWars.Kyu6.SupermarkQueue;

// todo https://www.codewars.com/kata/57b06f90e298a7b53d000a86/train/csharp
public class SupermarkQueue
{
    public long QueueTime(int[] customers, int n)
    {
        var tills = new int[n];
        var ticks = 0;
        while (customers.Any() || tills.Any(n => n > 0))
        {
            for (var i = 0; i < tills.Length; i++)
            {
                var currentTill = tills[i];
                if (currentTill == 0 && customers.Any())
                {
                    var customer = customers[^1];
                    tills[i] = customer;
                    customers = customers.SkipLast(1).ToArray();
                }
            }
            tills = tills.Select(t => t > 0 ? t - 1: t).ToArray();
            ticks++;
        }

        return ticks;
    }
}
