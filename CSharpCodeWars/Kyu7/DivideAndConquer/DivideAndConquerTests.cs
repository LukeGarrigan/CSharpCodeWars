using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu7.DivideAndConquer;

public class DivideAndConquerTests
{
      private DivideAndConquer _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new DivideAndConquer();
      }

      [Test]
      public void SampleTest()
      {
          Assert.AreEqual(2, _sut.DivCon(new object[] {9, 3, "7", "3"}));
          Assert.AreEqual(14, _sut.DivCon(new object[] {"5", "0", 9, 3, 2, 1, "9", 6, 7}));
          Assert.AreEqual(13, _sut.DivCon(new object[] {"3", 6, 6, 0, "5", 8, 5, "6", 2, "0"}));
          Assert.AreEqual(11, _sut.DivCon(new object[] {"1", "5", "8", 8, 9, 9, 2, "3"}));
          Assert.AreEqual(61, _sut.DivCon(new object[] {8, 0, 0, 8, 5, 7, 2, 3, 7, 8, 6, 7}));
          Assert.AreEqual(-6, _sut.DivCon(new object[] {"0", "1", "2", "3"}));
          Assert.AreEqual(6, _sut.DivCon(new object[] {0, 1, 2, 3}));
          Assert.AreEqual(0, _sut.DivCon(new object[] {1, "1"}));
          Assert.AreEqual(-2, _sut.DivCon(new object[] {-1, "1"}));
          Assert.AreEqual(2, _sut.DivCon(new object[] {1, "-1"}));
          Assert.AreEqual(1, _sut.DivCon(new object[] {1}));
          Assert.AreEqual(-1, _sut.DivCon(new object[] {"1"}));
          Assert.AreEqual(0, _sut.DivCon(new object[] { }));
      }
}
