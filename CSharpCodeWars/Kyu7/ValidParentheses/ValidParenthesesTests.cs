using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu7.ValidParentheses;

public class ValidParenthesesTests
{
      private ValidParentheses _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new ValidParentheses();
      }

      
      [Test]
      public void TestValidParentheses()
      {
          DoTest(true, "()");
          DoTest(true, "((()))");
          DoTest(true, "()()()");
          DoTest(true, "(()())()");
          DoTest(true, "()(())((()))(())()");
      }
  
      [Test]
      public void TestInvalidParentheses()
      {
          DoTest(false, ")(");
          // DoTest(false, "()()(");
          // DoTest(false, "((())");
          // DoTest(false, "())(()");
          // DoTest(false, ")()");
          // DoTest(false, ")");        
      }
  
      [Test]
      public void TestEmptyString()
      {
          DoTest(true, "");
      }
  
      private void DoTest(bool expected, string str) {
          Assert.AreEqual(expected, _sut.Valid(str), $"Incorrect answer for str = \"{str}\"");
      }
}
