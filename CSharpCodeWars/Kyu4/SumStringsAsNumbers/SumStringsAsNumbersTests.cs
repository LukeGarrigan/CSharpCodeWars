using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu4.SumStringsAsNumbers;

public class SumStringsAsNumbersTests
{
      private SumStringsAsNumbers _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new SumStringsAsNumbers();
      }

      [Test]
      public void Test1()
      {
           _sut.SumStrings("123", "456").Should().Be("579");
           _sut.SumStrings("123", "457").Should().Be("580");
           _sut.SumStrings("153", "469").Should().Be("622");
           _sut.SumStrings("153", "4690").Should().Be("4843");
          _sut.SumStrings("4690", "153").Should().Be("4843");
          _sut.SumStrings("999999", "999999").Should().Be("1999998");
      }
}
