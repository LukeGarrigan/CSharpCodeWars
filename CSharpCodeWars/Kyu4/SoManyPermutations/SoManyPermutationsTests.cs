using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu4.SoManyPermutations;

public class SoManyPermutationsTests
{
      private SoManyPermutations _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new SoManyPermutations();
      }

      [Test]
      public void Example1()
      {
          Assert.AreEqual(new List<string> { "a" }, _sut.SinglePermutations("a").OrderBy(x => x).ToList());
      }

      [Test]
      public void Example2()
      {
          Assert.AreEqual(new List<string> { "ab", "ba" }, _sut.SinglePermutations("ab").OrderBy(x => x).ToList());
      }

      [Test]
      public void Example3()
      {
          Assert.AreEqual(new List<string> { "aabb", "abab", "abba", "baab", "baba", "bbaa" }, _sut.SinglePermutations("aabb").OrderBy(x => x).ToList());
      }
}
