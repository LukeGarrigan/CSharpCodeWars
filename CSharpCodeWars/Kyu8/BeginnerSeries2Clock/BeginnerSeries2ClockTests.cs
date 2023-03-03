using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu8.BeginnerSeries2Clock;

public class BeginnerSeries2ClockTests
{
      private BeginnerSeries2Clock _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new BeginnerSeries2Clock();
      }

      [Test]
      public void Test()
      {
          Assert.AreEqual(61000, _sut.Past(0,1,1));
      }
}
