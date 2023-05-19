using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu5.Soundex;

public class SoundexTests
{
      private Soundex _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new Soundex();
      }

      [Test]
      public void Arnie()
      {
          Assert.AreEqual("S600 C560", _sut.CreateSoundex("Sarah Connor"));
          // Assert.AreEqual("S600 C560", Dinglemouse.Soundex("Sarah Connor"));
          // Assert.AreEqual("S600 C560", Dinglemouse.Soundex("Sarah Connor"));
          // Assert.AreEqual("S600 C560", Dinglemouse.Soundex("Sarah Connor"));
          // Assert.AreEqual("S600 C560", Dinglemouse.Soundex("Sarah Connor"));
      }
}
