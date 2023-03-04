using System;
namespace CSharpCodeWars.Kyu3.DecodeSecretEnemyMessages
{
    public class DecodeSecretEnemyMessages
    {

        public string Encode(string str)
        {
            var alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.,? #"; //todo the hash ain't right
      
            var output = "";

            var multiplier = 1;
            for (var i = 0; i < str.Length; i++)
            {
                // Hello World!
                // atC5kcOuKAr!
                var letterIndex = alphabet.IndexOf(str[i]);
                if (letterIndex == -1)
                {
                    output += str[i];
                    multiplier = (multiplier * 2) + 1;
                    continue;
                }
                var offset = (multiplier * letterIndex) + multiplier;
                
                // () 1x + 1
                //    1*1 + 1 = 2
                //    1*2 + 1 = 3
                //    1*3 + 1 = 4

                // (_) 3x + 3
                //     3*0 + 3 = 3
                //     3*1 + 3 = 6
                //     3*3 + 3 = 12
                
                // (__) 7x + 7  
                //      7*0 + 7 = 7
                //      7*1 + 7 = 14
                //      7*2 + 7 = 21
                
                // (___) 15x + 15    
                //     15*0 + 15 = 15
                //     15*1 + 15 = 30
                //     15*2 + 15 = 45

                var encodedIndex = letterIndex + offset;
                var actualIndex = encodedIndex % alphabet.Length;
                output += alphabet[actualIndex];
                multiplier = (multiplier * 2) + 1;
            }
            return output;
        }

        public string Decode(string str)
        {
            
            var alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789.,? #"; //todo the hash ain't right
            var output = "";
            for (var i = 0; i < str.Length; i++)
            {
                var currentLetter = str[i];
                if (!alphabet.Contains(currentLetter))
                {
                    output += currentLetter;
                }
                else
                {
                    var testString = "";
                    for (var k = 0; k < i; k++)
                    {
                        testString += "_";
                    }
                    for (var j = 0; j < alphabet.Length; j++)
                    {
                        testString += alphabet[j];
                        var result = Encode(testString);
                        if (result[result.Length - 1] == currentLetter)
                        {
                            output += alphabet[j];
                            break;
                        }
                        testString = testString.Remove(testString.Length - 1);
                    }

                  
                }
            }

            return output;
        }
    }
}
