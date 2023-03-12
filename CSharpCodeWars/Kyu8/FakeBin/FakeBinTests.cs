using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu8.FakeBin;

public class FakeBinTests
{
      private FakeBin _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new FakeBin();
      }

      [Test]
      public void BasicTests()
      {
          Assert.AreEqual("01011110001100111", _sut.ToFakeBin("45385593107843568"));
          Assert.AreEqual("101000111101101", _sut.ToFakeBin("509321967506747"));
          Assert.AreEqual("011011110000101010000011011", _sut.ToFakeBin("366058562030849490134388085"));
      }
}
