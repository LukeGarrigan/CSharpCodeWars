using System;
using System.Runtime.CompilerServices;

namespace CSharpCodeWars.Kyu8.CountTheLikes;

public class CountTheLikes
{
    public bool EvalLikes(string[] words)
    {
        // X / N = Y
        // X * Y = N
        return words.Count(w => w.ToLower() == "like") >= words.Length  * 0.05 ;
    }
}