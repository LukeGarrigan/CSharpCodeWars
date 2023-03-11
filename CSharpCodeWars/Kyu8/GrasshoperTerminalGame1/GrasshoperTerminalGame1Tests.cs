using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu8.GrasshoperTerminalGame1;

public class GrasshoperTerminalGame1Tests
{
    private GrasshoperTerminalGame1 _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new GrasshoperTerminalGame1();
    }

    [Test, Description("Hero should create a Hero")]
    public void InitTest()
    {
        Hero myHero = new Hero();
        Assert.AreEqual("Hero", myHero.Name);
    }

#pragma warning disable CS0183 // Suppress specific compiler warning, asserting a strongly typed property is that type will throw a warning
    [Test, Description("Hero should have appropriate types for its properties")]
    public void TypeTest()
    {
        Hero myHero = new Hero();
        Assert.That(myHero.Health is float);
    }
#pragma warning restore CS0183
}