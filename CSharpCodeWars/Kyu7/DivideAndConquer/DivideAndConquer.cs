using System;

namespace CSharpCodeWars.Kyu7.DivideAndConquer;

public class DivideAndConquer
{
    public int DivCon(Object[] objArray)
    {
        return objArray.Where(n => n is int).Sum(x => (int)x) - 
               objArray.Where(n => n is string).Select(Convert.ToInt32).Sum();
    }
}
