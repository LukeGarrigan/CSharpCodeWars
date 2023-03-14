using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu7.SortByLastChar;

public class SortByLastCharTests
{
    private SortByLastChar _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new SortByLastChar();
    }

    [Test]
    public void SampleTest()
    {
        Assert.AreEqual(new[] { "cba", "cab", "abc" }, _sut.Last("abc cba cab"));
        Assert.AreEqual(new[] { "aaa", "bbb", "ccc", "ddd" }, _sut.Last("bbb ccc aaa ddd"));
        Assert.AreEqual(new[] { "wa", "de", "co", "rs" }, _sut.Last("co de wa rs"));
        Assert.AreEqual(new[] { "axa", "ava", "asa" }, _sut.Last("axa ava asa"));
        
        Assert.AreEqual(new[] { "a", "need", "ubud", "i", "taxi", "man", "to", "up" },
            _sut.Last("man i need a taxi up to ubud"));
        
        Assert.AreEqual(new[] { "time", "are", "we", "the", "climbing", "volcano", "up", "what" },
            _sut.Last("what time are we climbing up the volcano"));
        
        Assert.AreEqual(new[] { "take", "me", "semynak", "to" }, _sut.Last("take me to semynak"));
        
        Assert.AreEqual(new[] { "massage", "massage", "massage", "yes", "yes" },
            _sut.Last("massage yes massage yes massage"));
        
        Assert.AreEqual(new[] { "a", "and", "take", "dance", "please", "bintang" },
            _sut.Last("take bintang and a dance please"));
    }
}