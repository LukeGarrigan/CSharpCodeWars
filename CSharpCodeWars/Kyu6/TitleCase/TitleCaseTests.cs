using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.TitleCase;

public class TitleCaseTests
{
      private TitleCase _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new TitleCase();
      }

      [TestCase("a clash of KINGS", "a an the of", "A Clash of Kings")]
      [TestCase("THE WIND IN THE WILLOWS", "The In", "The Wind in the Willows")]
      public void MyTest(string sampleTitle, string sampleMinorWords, string expected)
      {
          Assert.AreEqual(expected, _sut.ToTitleCase(sampleTitle, sampleMinorWords));
      }
      [Test]
      public void MyTest2()
      {
          Assert.AreEqual("", _sut.ToTitleCase(""));
      }
      [Test]
      public void FailingTest()
      {
          Assert.AreEqual("Abc Def Ghi", _sut.ToTitleCase("aBC deF Ghi", null));
      }
      
      [Test]
      public void MyTest3()
      {
          Assert.AreEqual("The Quick Brown Fox", _sut.ToTitleCase("the quick brown fox"));
      }
}
