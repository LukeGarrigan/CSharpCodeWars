using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.BitCounting;

public class BitCountingTests
{
      private BitCounting _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new BitCounting();
      }

      [Test]
      public void CountBits()
      {
          Assert.AreEqual(0, _sut.CountBits(0));
          Assert.AreEqual(1, _sut.CountBits(4));
          Assert.AreEqual(3, _sut.CountBits(7));
          Assert.AreEqual(2, _sut.CountBits(9));
          Assert.AreEqual(2, _sut.CountBits(10));
      }
}
