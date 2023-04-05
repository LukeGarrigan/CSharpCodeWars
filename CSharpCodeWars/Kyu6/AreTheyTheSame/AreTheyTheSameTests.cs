using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.AreTheyTheSame;

public class AreTheyTheSameTests
{
    private AreTheyTheSame _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new AreTheyTheSame();
    }

    [Test]
    public void Test1()
    {
        int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
        int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
        bool r = _sut.Comp(a, b); // True
        Assert.AreEqual(true, r);
    }
    
    [Test]
    public void Test2()
    {
        int[] a = new int[] { 122, 144, 19, 161, 19, 144, 19, 11 };
        int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
        bool r = _sut.Comp(a, b); // True
        Assert.AreEqual(false, r);
    }
}