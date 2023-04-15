using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu7.SummingANumbersDigits;

public class SummingANumbersDigitsTests
{
    private SummingANumbersDigits _sut;

    [SetUp]
    public void Setup()
    {
        _sut = new SummingANumbersDigits();
    }


    private static IEnumerable<TestCaseData> testCases
    {
        get
        {
            yield return new TestCaseData(10).Returns(1);
            yield return new TestCaseData(99).Returns(18);
            yield return new TestCaseData(-32).Returns(5);
        }
    }

    [Test, TestCaseSource("testCases")]
    public int FixedTest(int number) => _sut.SumDigits(number);
}