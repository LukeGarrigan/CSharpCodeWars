namespace CSharpCodeWars.Kyu6.DarwinTheory;

public class Creature
{
    private static readonly Dictionary<string, object> _chateristics = new();
    
    public object this[string wing]
    {
        get => _chateristics[wing];
        set => _chateristics[wing] = value;
    }
    
}
