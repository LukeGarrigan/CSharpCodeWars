using System;
namespace CSharpCodeWars.Kyu7.ListFiltering
{
    public class ListFiltering
    {
        public IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            // return listOfItems.Where(item => item is not string).Select(item => (int)item);
            return listOfItems.OfType<int>();
        }
    }
}
