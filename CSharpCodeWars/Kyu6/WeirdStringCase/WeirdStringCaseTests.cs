using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.WeirdStringCase;

public class WeirdStringCaseTests
{
      private WeirdStringCase _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new WeirdStringCase();
      }

      [Test]
      public void ShouldWorkForSomeExamples()
      {
          Assert.AreEqual("ThIs", _sut.ToWeirdCase("This"));
          Assert.AreEqual("Is", _sut.ToWeirdCase("is"));
          Assert.AreEqual("ThIs Is A TeSt", _sut.ToWeirdCase("This is a test"));
      }
}
