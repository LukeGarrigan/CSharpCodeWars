using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu7.RemoveTheMinmimum;

public class RemoveTheMinmimumTests
{
    private RemoveTheMinmimum _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new RemoveTheMinmimum();
    }

    private void Tester(List<int> argument, List<int> expectedResult)
    {
        CollectionAssert.AreEqual(expectedResult, _sut.RemoveSmallest(argument));
    }

    [Test]
    public void BasicTests()
    {
        Tester(new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 2, 3, 4, 5 });
        Tester(new List<int> { 5, 3, 2, 1, 4 }, new List<int> { 5, 3, 2, 4 });
        Tester(new List<int> { 1, 2, 3, 1, 1 }, new List<int> { 2, 3, 1, 1 });
        Tester(new List<int>(), new List<int>());
    }
}