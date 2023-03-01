using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.SortTheOdd;

public class SortTheOddTests
{
      private SortTheOdd _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new SortTheOdd();
      }

      [Test]
      public void BasicTests()
      {
          Assert.AreEqual(new int[] { 1, 3, 2, 8, 5, 4 }, _sut.SortArray(new int[] { 5, 3, 2, 8, 1, 4 }));
          Assert.AreEqual(new int[] { 1, 3, 5, 8, 0 }, _sut.SortArray(new int[] { 5, 3, 1, 8, 0 }));
          Assert.AreEqual(new int[] { }, _sut.SortArray(new int[] { }));
      }
}
