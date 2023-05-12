using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.BackspacesInString;

public class BackspacesInStringTests
{
      private BackspacesInString _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new BackspacesInString();
      }

      [Test]
      public void SampleTest()
      {
          Assert.AreEqual("ac", _sut.CleanString("abc#d##c"));
          Assert.AreEqual("", _sut.CleanString("abc####d##c#"));
      }
}
