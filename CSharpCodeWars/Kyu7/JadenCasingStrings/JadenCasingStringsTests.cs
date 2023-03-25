using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu7.JadenCasingStrings;

public class JadenCasingStringsTests
{
      
      [SetUp]
      public void Setup()
      {
      }

      [Test]
      public void FixedTest()
      {
          Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real",
              "How can mirrors be real if our eyes aren't real".ToJadenCase(),
              "Strings didn't match.");
      }
}
