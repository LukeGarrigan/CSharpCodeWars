using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.BouncingBalls;

public class BouncingBallsTests
{
      private BouncingBalls _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new BouncingBalls();
      }

      [Test]
      public void Test1() {
          Assert.AreEqual(3, _sut.BouncingBall(3.0, 0.66, 1.5));
      }
      [Test]
      public void Test2() {
          Assert.AreEqual(15, _sut.BouncingBall(30.0, 0.66, 1.5));
      }
}
