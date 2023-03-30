using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.RemoveTheParentheses;

public class RemoveTheParenthesesTests
{
    private RemoveTheParentheses _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new RemoveTheParentheses();
    }

    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("exampleexample", _sut.RemoveParentheses("example(unwanted thing)example"));
        Assert.AreEqual("example  example", _sut.RemoveParentheses("example (unwanted thing) example"));
        Assert.AreEqual("a e", _sut.RemoveParentheses("a (bc d)e"));
        Assert.AreEqual("a", _sut.RemoveParentheses("a(b(c))"));
        Assert.AreEqual("hello example  something",
            _sut.RemoveParentheses("hello example (words(more words) here) something"));
        Assert.AreEqual("  ", _sut.RemoveParentheses("(first group) (second group) (third group)"));
        Assert.AreEqual("trxV", _sut.RemoveParentheses("((Sevo MTA pSfhe ))trxV"));
    }
}