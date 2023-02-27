using NUnit.Framework;
using Interval = System.ValueTuple<int, int>;

namespace CSharpCodeWars.Kyu4.SumOfIntervals;

public class SumOfIntervalsTests
{
    private SumOfIntervals _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new SumOfIntervals();
    }
    
    [Test]
    public void ShouldHandleEmptyIntervals()
    {
        Assert.AreEqual(0, _sut.SumIntervals(new Interval[] { }));
        Assert.AreEqual(0, _sut.SumIntervals(new Interval[] { (4, 4), (6, 6), (8, 8) }));
    }

    [Test]
    public void ShouldAddDisjoinedIntervals()
    {
        Assert.AreEqual(9, _sut.SumIntervals(new Interval[] { (1, 2), (6, 10), (11, 15) }));
        Assert.AreEqual(11, _sut.SumIntervals(new Interval[] { (4, 8), (9, 10), (15, 21) }));
        Assert.AreEqual(7, _sut.SumIntervals(new Interval[] { (-1, 4), (-5, -3) }));
        Assert.AreEqual(78, _sut.SumIntervals(new Interval[] { (-245, -218), (-194, -179), (-155, -119) }));
    }

    [Test]
    public void ShouldAddAdjacentIntervals()
    {
        Assert.AreEqual(54, _sut.SumIntervals(new Interval[] { (1, 2), (2, 6), (6, 55) }));
        Assert.AreEqual(23, _sut.SumIntervals(new Interval[] { (-2, -1), (-1, 0), (0, 21) }));
    }

    [Test]
    public void ShouldAddOverlappingIntervals()
    {
        Assert.AreEqual(7, _sut.SumIntervals(new Interval[] { (1, 4), (7, 10), (3, 5) }));
        Assert.AreEqual(6, _sut.SumIntervals(new Interval[] { (5, 8), (3, 6), (1, 2) }));
        Assert.AreEqual(19, _sut.SumIntervals(new Interval[] { (1, 5), (10, 20), (1, 6), (16, 19), (5, 11) }));
    }

    [Test]
    public void ShouldHandleMixedIntervals()
    {
        Assert.AreEqual(13, _sut.SumIntervals(new Interval[] { (2, 5), (-1, 2), (-40, -35), (6, 8) }));
        Assert.AreEqual(1234,
            _sut.SumIntervals(new Interval[] { (-7, 8), (-2, 10), (5, 15), (2000, 3150), (-5400, -5338) }));
        Assert.AreEqual(158,
            _sut.SumIntervals(new Interval[] { (-101, 24), (-35, 27), (27, 53), (-105, 20), (-36, 26) }));
    }

    [Test]
    public void ShouldHandleLargeIntervals()
    {
        Assert.AreEqual(2_000_000_000, _sut.SumIntervals(new Interval[] { (-1_000_000_000, 1_000_000_000) }));
        Assert.AreEqual(100_000_030, _sut.SumIntervals(new Interval[] { (0, 20), (-100_000_000, 10), (30, 40) }));
    }

    [Test]
    public void ShouldHandleSmallRandomIntervals()
    {
        Assert.AreEqual(145, _sut.SumIntervals(new Interval[] { (-400, -399), (317, 334), (-473, -470), (236, 237), (152, 164), (236, 237), (-334, -330), (-99, -79), (-170, -167), (-361, -358), (411, 428), (-242, -223), (219, 233), (-100, -97), (-377, -373), (-438, -424), (-281, -272), (220, 237) }));
    }
}