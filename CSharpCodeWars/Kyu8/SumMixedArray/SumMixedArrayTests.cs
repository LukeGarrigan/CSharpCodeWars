using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu8.SumMixedArray;

public class SumMixedArrayTests
{
      private SumMixedArray _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new SumMixedArray();
      }

      [Test]
      public void SampleTest()
      {
          Assert.AreEqual(22, _sut.SumMix(new object[] {9, 3, "7", "3"}));
          Assert.AreEqual(42, _sut.SumMix(new object[] {"5", "0", 9, 3, 2, 1, "9", 6, 7})); 
          Assert.AreEqual(41, _sut.SumMix(new object[] {"3", 6, 6, 0, "5", 8, 5, "6", 2, "0"}));
      }
}
