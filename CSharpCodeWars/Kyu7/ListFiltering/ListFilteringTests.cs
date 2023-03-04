using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu7.ListFiltering;

public class ListFilteringTests
{
      private ListFiltering _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new ListFiltering();
      }

      [Test]
      public void GetIntegersFromList_MixedValues_ShouldPass_1()
      {
          var list = new List<object>(){1,2,"a","b"};
          var expected = new List<int>(){1,2};
          var actual = _sut.GetIntegersFromList(list);
          Assert.IsTrue(expected.SequenceEqual(actual));
      }
      [Test]
      public void GetIntegersFromList_MixedValues_ShouldPass_2()
      {
          var list = new List<object>(){1,"a","b",0,15};
          var expected = new List<int>(){1,0,15};
          var actual = _sut.GetIntegersFromList(list);
          Assert.IsTrue(expected.SequenceEqual(actual));
      }
      [Test]
      public void GetIntegersFromList_MixedValues_ShouldPass_3()
      {
          var list = new List<object>(){1,2,"aasf","1","123",123};
          var expected = new List<int>(){1,2,123};
          var actual = _sut.GetIntegersFromList(list);
          Assert.IsTrue(expected.SequenceEqual(actual));
      }
}
