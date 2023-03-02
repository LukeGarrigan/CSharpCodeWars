using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu7.SumOfTwoLowestIntegers;

public class SumOfTwoLowestIntegersTests
{
      private SumOfTwoLowestIntegers _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new SumOfTwoLowestIntegers();
      }

      [Test]
      public void Test1()
      {
          int[] numbers = {5, 8, 12, 19, 22};
          Assert.AreEqual(13, _sut.SumTwoSmallestNumbers(numbers));		
      }
  
      [Test]
      public void Test2()
      {
          int[] numbers = {19, 5, 42, 2, 77};
          Assert.AreEqual(7, _sut.SumTwoSmallestNumbers(numbers));		
      }
  
      [Test]
      public void Test3()
      {
          int[] numbers = {10, 343445353, 3453445, 2147483647};
          Assert.AreEqual(3453455, _sut.SumTwoSmallestNumbers(numbers));		
      }
}
