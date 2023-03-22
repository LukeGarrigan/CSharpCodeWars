using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu4.NextBiggerNumber;

public class NextBiggerNumberTests
{
      private NextBiggerNumber _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new NextBiggerNumber();
      }

      [Test]
      public void SmallNumbers()
      {
          //Assert.AreEqual(1234567908, _sut.NextBigger(1234567890));
          Assert.AreEqual(21, _sut.NextBigger(12));
          Assert.AreEqual(531, _sut.NextBigger(513));
          Assert.AreEqual(2071, _sut.NextBigger(2017));
          Assert.AreEqual(441, _sut.NextBigger(414));
          Assert.AreEqual(414, _sut.NextBigger(144));
      }
}
