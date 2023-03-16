using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu4.StripComments;

public class StripCommentsTests
{
      private StripComments _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new StripComments();
      }

      [Test]
      public void StripComments()
      {
          Assert.AreEqual(
              "apples, pears\ngrapes\nbananas",
              _sut.Strip("apples, pears # and bananas\ngrapes\nbananas !apples", new string[] { "#", "!" }));
          
          Assert.AreEqual("a\nc\nd", _sut.Strip("a #b\nc\nd $e f g", new string[] { "#", "$" }));
          Assert.AreEqual("grapes\n pears", _sut.Strip("grapes#yh\n pears   ", new string[] { "#" }));
          Assert.AreEqual("grapes\n pears\n yes", _sut.Strip("grapes#yh\n pears   \n yes", new string[] { "#" }));
          Assert.AreEqual("", _sut.Strip("#", new string[] { "#" }));
          Assert.AreEqual("", _sut.Strip("a", new string[] { "a" }));

      } 
}
