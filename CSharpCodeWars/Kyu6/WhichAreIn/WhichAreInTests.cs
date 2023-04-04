using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.WhichAreIn;

public class WhichAreInTests
{
    private WhichAreIn _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new WhichAreIn();
    }

    [Test]
    public void Test1()
    {
        string[] a1 = new string[] { "arp", "live", "strong" };
        string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
        string[] r = new string[] { "arp", "live", "strong" };
        Assert.AreEqual(r, _sut.InArray(a1, a2));
    }
}