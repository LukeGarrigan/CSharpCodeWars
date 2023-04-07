using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu5.SimplePigLatin;

public class SimplePigLatinTests
{
      private SimplePigLatin _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new SimplePigLatin();
      }

      [Test]
      public void KataTests()
      {
          Assert.AreEqual("igPay atinlay siay oolcay", _sut.PigIt("Pig latin is cool"));
          Assert.AreEqual("hisTay siay ymay tringsay", _sut.PigIt("This is my string"));
      }
}
