using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.MorseCodeDecoder;

public class MorseCodeDecoderTests
{
      private MorseCodeDecoder _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new MorseCodeDecoder();
      }

      [Test]
      public void MorseCodeDecoderBasicTest_1()
      {
          try
          {
              string input = ".... . -.--   .--- ..- -.. .";
              string expected = "HEY JUDE";

              string actual = _sut.Decode(input);

              Assert.AreEqual(expected, actual);
          }
          catch(Exception ex)
          {
              Assert.Fail("There seems to be an error somewhere in your code. Exception message reads as follows: " + ex.Message);
          }
      }
}
