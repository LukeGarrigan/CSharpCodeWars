using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu7.FindTheNextPerfectSquare;

public class FindTheNextPerfectSquareTests
{
    private FindTheNextPerfectSquare _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new FindTheNextPerfectSquare();
    }

    [Test]
    [TestCase(155, ExpectedResult = -1)]
    [TestCase(121, ExpectedResult = 144)]
    [TestCase(625, ExpectedResult = 676)]
    [TestCase(319225, ExpectedResult = 320356)]
    [TestCase(15241383936, ExpectedResult = 15241630849)]
    [TestCase(4503599627370496, ExpectedResult = 4503599761588225)]
    // [TestCase(4503599627370497, ExpectedResult = -1)]
    // [TestCase(1989601352416902436, ExpectedResult = 1989601355237967025)]
    public long Test1(long num)
    {
        return _sut.FindNextSquare(num);
    }
}