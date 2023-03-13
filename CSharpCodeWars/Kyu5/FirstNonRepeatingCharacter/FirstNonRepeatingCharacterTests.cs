using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu5.FirstNonRepeatingCharacter;

public class FirstNonRepeatingCharacterTests
{
      private FirstNonRepeatingCharacter _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new FirstNonRepeatingCharacter();
      }

      [Test]
      public void BasicTests()
      {
          Assert.AreEqual("a", _sut.FirstNonRepeatingLetter("a"));
          Assert.AreEqual("t", _sut.FirstNonRepeatingLetter("stress"));
          Assert.AreEqual("e", _sut.FirstNonRepeatingLetter("moonmen"));
          Assert.AreEqual("", _sut.FirstNonRepeatingLetter("aaaaabb"));
      }    
}
