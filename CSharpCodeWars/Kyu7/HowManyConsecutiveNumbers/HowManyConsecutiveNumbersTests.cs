using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu7.HowManyConsecutiveNumbers;

public class HowManyConsecutiveNumbersTests
{
      private HowManyConsecutiveNumbers _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new HowManyConsecutiveNumbers();
      }

      [Test]
      public void BasicTests()
      {
          Assert.AreEqual(2, _sut.Consecutive(new int[] { 4, 8, 6 }));
          Assert.AreEqual(0, _sut.Consecutive(new int[] { 1, 2, 3, 4 }));
          Assert.AreEqual(0, _sut.Consecutive(new int[] { }));
          Assert.AreEqual(0, _sut.Consecutive(new int[] { 1 }));
      }
}
