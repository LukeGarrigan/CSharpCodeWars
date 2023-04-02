using System;
using System.Net;

namespace CSharpCodeWars.Kyu5.Int32ToIPv4;

public class Int32ToIPv4
{
    public string ToIPv4(uint number)
    {
        var binary = Convert.ToString(number, 2);
        var numbers = new List<int>();
        while (binary.Length > 0)
        {
            if (binary.Length >= 8)
            {
                
                // Substring(startIndex, Length - startIndex);
                // so a substring like binary.length -8 equates to the overload
                // Substring(binary.Length -8, Length - binary.Length -8)
                // Length = 10
                // Substring(2, 8)
                
                numbers.Add(Convert.ToInt32(binary.Substring(binary.Length - 8), 2));
                binary = binary.Substring(0, binary.Length - 8);
            }
            else
            {
                numbers.Add(Convert.ToInt32(binary, 2));
                binary = "";
            }    
        }
        
        while (numbers.Count < 4)
        {
            numbers.Add(0);
        }
        
        numbers.Reverse();
        return string.Join(".", numbers);
    }
    // could just make use of the IPAddress utility
    // return IPAddress.Parse(number.ToString()).ToString();

}
