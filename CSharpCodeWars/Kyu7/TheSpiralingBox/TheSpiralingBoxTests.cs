using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu7.TheSpiralingBox;

public class TheSpiralingBoxTests
{
    private TheSpiralingBox _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new TheSpiralingBox();
    }

    [Test]
    public void sampleTests()
    {
        int[,] box_7_8 =
        {
            { 1, 1, 1, 1, 1, 1, 1 },
            { 1, 2, 2, 2, 2, 2, 1 },
            { 1, 2, 3, 3, 3, 2, 1 },
            { 1, 2, 3, 4, 3, 2, 1 },
            { 1, 2, 3, 4, 3, 2, 1 },
            { 1, 2, 3, 3, 3, 2, 1 },
            { 1, 2, 2, 2, 2, 2, 1 },
            { 1, 1, 1, 1, 1, 1, 1 }
        };

        int[,] box_8_7 =
        {
            { 1, 1, 1, 1, 1, 1, 1, 1 },
            { 1, 2, 2, 2, 2, 2, 2, 1 },
            { 1, 2, 3, 3, 3, 3, 2, 1 },
            { 1, 2, 3, 4, 4, 3, 2, 1 },
            { 1, 2, 3, 3, 3, 3, 2, 1 },
            { 1, 2, 2, 2, 2, 2, 2, 1 },
            { 1, 1, 1, 1, 1, 1, 1, 1 }
        };

        int[,] box_4_2 = { { 1, 1, 1, 1 }, { 1, 1, 1, 1 } };

        int[,] box_2_4 = { { 1, 1 }, { 1, 1 }, { 1, 1 }, { 1, 1 } };

        CollectionAssert.AreEqual(box_7_8, _sut.CreateBox(7, 8));

        CollectionAssert.AreEqual(box_8_7, _sut.CreateBox(8, 7));

        CollectionAssert.AreEqual(box_4_2, _sut.CreateBox(4, 2));

        CollectionAssert.AreEqual(box_2_4, _sut.CreateBox(2, 4));
    }
}