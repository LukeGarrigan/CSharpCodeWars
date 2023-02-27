using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu7.DisemvowelTrolls;

public class DisemvowelTrollsTests
{
      private DisemvowelTrolls _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new DisemvowelTrolls();
      }

      [Test]
      public void ShouldRemoveAllVowels()
      {
          Assert.AreEqual("Ths wbst s fr lsrs LL!", _sut.Disemvowel("This website is for losers LOL!"));
      }
    
      [Test]
      public void MultilineString()
      {
          Assert.AreEqual("N ffns bt,\nYr wrtng s mng th wrst 'v vr rd", _sut.Disemvowel("No offense but,\nYour writing is among the worst I've ever read"));
      }
  
      [Test]
      public void OneMoreForGoodMeasure()
      {
          Assert.AreEqual("Wht r y,  cmmnst?", _sut.Disemvowel("What are you, a communist?"));
      }
}
