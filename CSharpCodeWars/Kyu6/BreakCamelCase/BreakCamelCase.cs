namespace CSharpCodeWars.Kyu6.BreakCamelCase
{
    public class BreakCamelCase
    {
        public string Solve(string str)
        {
            return str.Aggregate("", (current, c) => current + (char.IsUpper(c) ? $" {c}" : c));
        }
    }
}
