using System;

namespace CSharpCodeWars.Kyu6.SimpleEncryption1AlternatingSplit;

public class SimpleEncryption1AlternatingSplit
{
    public string Encrypt(string text, int n)
    {
        for (var i = 0; i < n; i++)
        {
            var evens = text.Where((c, i) => i % 2 == 0);
            var odds = text.Where((c, i) => i % 2 == 1);

            text = string.Concat(odds.Concat(evens));
        }


        return text;
    }

    public string Decrypt(string encryptedText, int n)
    {
        for (var i = 0; i < n; i++)
        {
            var end = encryptedText.Substring(encryptedText.Length / 2);
            var start = encryptedText.Substring(0, encryptedText.Length / 2);

            var output = "";
            for (var j = 0; j < start.Length; j++)
            {
                output += end[j] + ""+ start[j];
            }
            

            if (output.Length < encryptedText.Length)
            {
                if (start.Length > end.Length)
                {
                    output += start[^1];
                }
                else
                {
                    output += end[^1];
                }
            }
            encryptedText = output;
        }

        return encryptedText;
    }
}