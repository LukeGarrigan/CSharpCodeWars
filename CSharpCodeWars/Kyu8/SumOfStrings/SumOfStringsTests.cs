using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu8.SumOfStrings;

public class SumOfStringsTests
{
      private SumOfStrings _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new SumOfStrings();
      }

      [Test(Description = "Tests")]
      public void Tests()
      {
          Assert.AreEqual("9", _sut.StringSums("4","5"));
          Assert.AreEqual("39", _sut.StringSums("34","5"));
          Assert.AreEqual("9", _sut.StringSums("","9"));
          Assert.AreEqual("9", _sut.StringSums("9",""));
          Assert.AreEqual("0", _sut.StringSums("",""));
      }
}
