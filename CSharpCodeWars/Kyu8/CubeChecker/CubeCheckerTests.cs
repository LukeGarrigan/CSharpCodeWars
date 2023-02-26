using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu8.CubeChecker;

public class CubeCheckerTests
{
      private CubeChecker _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new CubeChecker();
      }

      [Test]
      public void Test1()
      {
          _sut.IsCube(8, 2).Should().BeTrue();
          _sut.IsCube(0, 0).Should().BeFalse();
          Assert.AreEqual(false, _sut.IsCube(2, 1));
          Assert.AreEqual(false, _sut.IsCube(6, 3));
          Assert.AreEqual(false, _sut.IsCube(-8, -2));
          Assert.AreEqual(false, _sut.IsCube(0, 0));
          Assert.AreEqual(false, _sut.IsCube(200, 4));
      }
}
