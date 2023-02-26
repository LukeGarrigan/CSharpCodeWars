using FluentAssertions;
using NUnit.Framework;

namespace CSharpCodeWars.Kyu7.IndexedCapitalization;

public class IndexedCapitalizationTests
{
      private IndexedCapitalization _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new IndexedCapitalization();
      }

      [Test]
      public void Test1()
      {
          _sut.Capitalize("abcdef", new List<int>() { 1, 2, 5 }).Should().Be("aBCdeF");
      }
}
