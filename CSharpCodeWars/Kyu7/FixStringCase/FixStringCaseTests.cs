using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu7.FixStringCase;

public class FixStringCaseTests
{
      private FixStringCase _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new FixStringCase();
      }

      [TestCase("code", "code")]
      [TestCase("CODe", "CODE")]
      [TestCase("COde", "code")]
      [TestCase("Code", "code")]
      public void BasicTests(string s, string expected)
      {
          Assert.That(_sut.Solve(s), Is.EqualTo(expected));
      }
}
