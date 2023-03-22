using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.CountCharsInYourString;

public class CountCharsInYourStringTests
{
      private CountCharsInYourString _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new CountCharsInYourString();
      }

      [Test]
      public void FixedTest_aaaa()
      {
          Dictionary<char, int> d = new Dictionary<char, int>();
          d.Add('a', 4);
          Assert.AreEqual(d, _sut.Count("aaaa"));
      }
  
      [Test]
      public void FixedTest_aabb()
      {
          Dictionary<char, int> d = new Dictionary<char, int>();
          d.Add('a', 2);
          d.Add('b', 2);
          Assert.AreEqual(d, _sut.Count("aabb"));
      }
}
