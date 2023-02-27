using System;
namespace CSharpCodeWars.Kyu7.FriendOrFoe
{
    public class FriendOrFoe
    {
        public IEnumerable<string> IsFriendOrFoe(string[] names)
        {
            return names.Where(name => name.Length == 4);
        }
    }
}
