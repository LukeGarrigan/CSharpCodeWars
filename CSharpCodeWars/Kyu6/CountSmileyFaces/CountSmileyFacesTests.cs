using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.CountSmileyFaces;

public class CountSmileyFacesTests
{
      private CountSmileyFaces _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new CountSmileyFaces();
      }

      [Test]
      public void BasicTest()
      {
          Assert.AreEqual(4, _sut.CountSmileys(new string[] { ":D", ":~)", ";~D", ":)" }));
          Assert.AreEqual(2, _sut.CountSmileys(new string[] { ":)", ":(", ":D", ":O", ":;" }));
          Assert.AreEqual(1, _sut.CountSmileys(new string[] { ";]", ":[", ";*", ":$", ";-D" }));
          Assert.AreEqual(0, _sut.CountSmileys(new string[] { ";", ")", ";*", ":$", "8-D" }));
          Assert.AreEqual(1, _sut.CountSmileys(new string[] {  "; )",  "8~)",  ":~)",   "P",  ":(",  ";~(",  ";-P",  "; P" }));
          Assert.AreEqual(1, _sut.CountSmileys(new string[] {  "8~(",  ": )",  "~(",  "8P",  ";D", ")"  }));
      }
}
