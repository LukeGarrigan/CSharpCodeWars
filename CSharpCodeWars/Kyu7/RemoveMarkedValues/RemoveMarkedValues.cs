using System;

namespace CSharpCodeWars.Kyu7.RemoveMarkedValues;

public class RemoveMarkedValues
{
    public int[] Remove(int[] intList, int[] valuesList) => intList.Where(v => !valuesList.Contains(v)).ToArray();
    
}
