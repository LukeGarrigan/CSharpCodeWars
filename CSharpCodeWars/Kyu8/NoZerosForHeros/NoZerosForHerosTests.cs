using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu8.NoZerosForHeros;

public class NoZerosForHerosTests
{
    private NoZerosForHeros _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new NoZerosForHeros();
    }

    [Test]
    public void test1()
    {
        Console.WriteLine("Basic Tests NoBoringZeros");
        Testing(_sut.NoBoringZeros(1450), 145);
        Testing(_sut.NoBoringZeros(960000), 96);
        Testing(_sut.NoBoringZeros(1050), 105);
        Testing(_sut.NoBoringZeros(-1050), -105);
    }
    
    private void Testing(int actual, int expected) 
    {
        Assert.AreEqual(expected, actual);
    }
}