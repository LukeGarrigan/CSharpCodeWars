using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.BreakCamelCase;

public class BreakCamelCaseTests
{
    private BreakCamelCase _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new BreakCamelCase();
    }

    [Test]
    public void Test()
    {
        _sut.Solve("camelCasing").Should().Be("camel Casing");
        _sut.Solve("camelCasingTest").Should().Be("camel Casing Test");
    }
}