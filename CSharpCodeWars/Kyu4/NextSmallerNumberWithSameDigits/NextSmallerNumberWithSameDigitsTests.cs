using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu4.NextSmallerNumberWithSameDigits;

public class NextSmallerNumberWithSameDigitsTests
{
      private NextSmallerNumberWithSameDigits _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new NextSmallerNumberWithSameDigits();
      }

      
      
      [TestCase(1262347, ExpectedResult = 1247632)]
      [TestCase(21, ExpectedResult = 12)]
      [TestCase(907, ExpectedResult = 790)]
      [TestCase(531, ExpectedResult = 513)]
      [TestCase(1027, ExpectedResult = -1)]
      [TestCase(441, ExpectedResult = 414)]
      [TestCase(123456798, ExpectedResult = 123456789)]
      [TestCase(123456798842112, ExpectedResult = 123456798841221)]
      [TestCase(123456789, ExpectedResult = 123456789)]
      public long FixedTests(long n)
      {
          return _sut.NextSmaller(n);
      }
}
