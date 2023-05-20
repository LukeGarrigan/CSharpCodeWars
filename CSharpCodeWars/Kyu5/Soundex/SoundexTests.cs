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
          // Assert.AreEqual("S600 C560", _sut.CreateSoundex("Sarah Connor"));
          // Assert.AreEqual("R163", _sut.CreateSoundex("Robert"));
          // Assert.AreEqual("R163", _sut.CreateSoundex("Rupert"));
          // Assert.AreEqual("R150", _sut.CreateSoundex("Rubin"));
          // Assert.AreEqual("T522", _sut.CreateSoundex("Tymczak"));
          // Assert.AreEqual("P236", _sut.CreateSoundex("Pfister"));
          // Assert.AreEqual("H555", _sut.CreateSoundex("Honeyman"));
          Assert.AreEqual("E451", _sut.CreateSoundex("elmviina"));
          // Assert.AreEqual("S600 C560", Dinglemouse.Soundex("Sarah Connor"));
          // Assert.AreEqual("S600 C560", Dinglemouse.Soundex("Sarah Connor"));
          // Assert.AreEqual("S600 C560", Dinglemouse.Soundex("Sarah Connor"));
      }
}
