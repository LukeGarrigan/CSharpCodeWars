using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu7.ShortestWord;

public class ShortestWordTests
{
      private ShortestWord _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new ShortestWord();
      }

      [Test]
      public void BasicTests()
      {
          Assert.AreEqual(3, _sut.FindShort("bitcoin take over the world maybe who knows perhaps"));
          Assert.AreEqual(3, _sut.FindShort("turns out random test cases are easier than writing out basic ones"));      
          Assert.AreEqual(2, _sut.FindShort("Let's travel abroad shall we"));
      }
}
