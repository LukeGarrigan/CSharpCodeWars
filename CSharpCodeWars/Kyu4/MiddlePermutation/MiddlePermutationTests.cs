using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu4.MiddlePermutation;

public class GetMiddlePermutationTests
{
    private MiddlePermutation _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new MiddlePermutation();
    }

    [Test]
    public void BasicTests()
    {
        Assert.AreEqual("bac", _sut.GetMiddlePermutation("abc"));
        
        Assert.AreEqual("bdca", _sut.GetMiddlePermutation("abcd"));
        
        Assert.AreEqual("cbxda", _sut.GetMiddlePermutation("abcdx"));
        
        Assert.AreEqual("cxgdba", _sut.GetMiddlePermutation("abcdxg"));
        
        Assert.AreEqual("dczxgba", _sut.GetMiddlePermutation("abcdxgz"));
        Assert.AreEqual("dczxgba", _sut.GetMiddlePermutation("abcdefgijklmnosdqwekgkskqr"));
    }
}