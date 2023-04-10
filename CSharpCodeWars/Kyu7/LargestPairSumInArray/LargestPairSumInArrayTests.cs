using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu7.LargestPairSumInArray;

public class LargestPairSumInArrayTests
{
      private LargestPairSumInArray _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new LargestPairSumInArray();
      }

      [Test]
      public void Test1()
      {
          Assert.AreEqual(-16, _sut.LargestPairSum(new int[] {-8, -8, -16, -18, -19}));
          Assert.AreEqual(0, _sut.LargestPairSum(new int[] {-100, -29, -24, -19, 19}));
          Assert.AreEqual(10, _sut.LargestPairSum(new int[] {1, 2, 3, 4, 6, -1, 2}));
          Assert.AreEqual(42, _sut.LargestPairSum(new int[] {10, 14, 2, 23, 19}));
      }
}
