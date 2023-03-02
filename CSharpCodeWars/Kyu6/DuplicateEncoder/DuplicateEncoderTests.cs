using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.DuplicateEncoder;

public class DuplicateEncoderTests
{
      private DuplicateEncoder _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new DuplicateEncoder();
      }

      [Test]
      public void Test1()
      {
          Assert.AreEqual("(((", _sut.DuplicateEncode("din"));
          Assert.AreEqual("()()()", _sut.DuplicateEncode("recede"));
          Assert.AreEqual(")())())", _sut.DuplicateEncode("Success"), "should ignore case");
          Assert.AreEqual("))((", _sut.DuplicateEncode("(( @"));
      }
}
