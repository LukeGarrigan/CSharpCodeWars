using System;

namespace CSharpCodeWars.Kyu8.GrassHoperPersonalisedMessage;

public class GrassHoperPersonalisedMessage
{
    public string Greet(string name, string owner)
    {
        return  $"Hello {(name == owner ? "boss" : "guest")}";
    }
}
