using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu7.SumOfTheFirstNthTermOfSeries;

public class SumOfTheFirstNthTermOfSeriesTests
{
      private SumOfTheFirstNthTermOfSeries _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new SumOfTheFirstNthTermOfSeries();
      }

      [Test]
      public void Test1() {
          Assert.AreEqual("0.00", _sut.SeriesSum(0));
      }
      [Test]
      public void Test2() {
          Assert.AreEqual("1.77", _sut.SeriesSum(9));
      }
      [Test]
      [TestCase(1, "1.00")]
      [TestCase(2, "1.25")]
      [TestCase(5, "1.57")]
      public void Test3(int input, string output) {
          Assert.AreEqual(output, _sut.SeriesSum(input));
      }
}
