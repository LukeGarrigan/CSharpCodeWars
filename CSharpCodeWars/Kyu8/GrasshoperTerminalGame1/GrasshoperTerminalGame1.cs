using System;

namespace CSharpCodeWars.Kyu8.GrasshoperTerminalGame1;

public class GrasshoperTerminalGame1
{

    
}

public class Hero
{
    public string Name { get; set; } = "Hero";
    public string Position { get; set; } = "00";
    public float Health { get; set; } = 100;
    public float Damage { get; set; } = 5;
    public int Experience { get; set; } = 0;

    public Hero(string name = "hero")
    {
        Name = name;
    }
}