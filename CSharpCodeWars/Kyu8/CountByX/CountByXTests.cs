using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu8.CountByX;

public class CountByXTests
{
      private CountByX _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new CountByX();
      }

      [Test]
      public void CountBy1()
      {
          Assert.AreEqual(new int[] {1,2,3,4,5}, _sut.CountBy(1,5), "Array does not match");
      }
  
      [Test]
      public void CountBy2()
      {
          Assert.AreEqual(new int[] {2,4,6,8,10}, _sut.CountBy(2,5), "Array does not match");
      }
}
