using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu4.AllBalancedParentheses;

public class AllBalancedParenthesesTests
{
      private AllBalancedParentheses _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new AllBalancedParentheses();
      }

      [Test]
      public void TestExample()
      {
          var warriorsList = new List<string>();
          warriorsList = _sut.BalancedParens(0);
          Assert.AreEqual(new List<string> { "" }, warriorsList);
          warriorsList = _sut.BalancedParens(1);
          Assert.AreEqual(new List<string> { "()" }, warriorsList);
          warriorsList = _sut.BalancedParens(2);
          warriorsList.Sort();
          Assert.AreEqual(new List<string> { "(())", "()()" }, warriorsList);
          warriorsList = _sut.BalancedParens(3);
          Assert.AreEqual(new List<string> { "((()))", "(()())", "(())()", "()(())", "()()()" }, warriorsList);
          warriorsList = _sut.BalancedParens(4);
          warriorsList.Sort();
          Assert.AreEqual(new List<string> { "(((())))", "((()()))", "((())())", "((()))()", "(()(()))", "(()()())", "(()())()", "(())(())", "(())()()", "()((()))", "()(()())", "()(())()", "()()(())", "()()()()" }, warriorsList);
      }
}
