using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu7.AverageOfNumbers;

public class AverageOfNumbersTests
{
      private AverageOfNumbers _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new AverageOfNumbers();
      }

      [Test]
      public void BasicTests()
      {
         // Assert.AreEqual(string.Join(", ", new double[] { 2, 2, 2, 2 }), string.Join(", ", _sut.Averages(new int[] { 2, 2, 2, 2, 2 })));
          Assert.AreEqual(string.Join(", ", new double[] { 0, 0, 0, 0 }), string.Join(", ", _sut.Averages(new int[] { 2, -2, 2, -2, 2 })));
         // Assert.AreEqual(string.Join(", ", new double[] { 2, 4, 3, -4.5 }), string.Join(", ", _sut.Averages(new int[] { 1, 3, 5, 1, -10 })));
      }
}
