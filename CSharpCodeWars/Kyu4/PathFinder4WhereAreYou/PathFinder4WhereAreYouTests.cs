using System.Drawing;
using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu4.PathFinder4WhereAreYou;

public class PathFinder4WhereAreYouTests
{
    [TestFixture]
    public class SolutionTest
    {
        [TestCaseSource("samples")]
        public void MyTest(string s, Point p)
        {
            Assert.AreEqual(p, PathFinder4WhereAreYou.IAmHere(s));
        }

        static TestCaseData[] samples =
        {
            new TestCaseData("", new Point(0, 0)).SetName("Sample Test"),
            new TestCaseData("RLrl", new Point(0, 0)).SetName("Sample Test"),
            new TestCaseData("r5L2l4", new Point(4, 3)).SetName("Sample Test"),
            new TestCaseData("r5L2l4", new Point(0, 0)).SetName("Sample Test"),
            new TestCaseData("10r5r0", new Point(-10, 5)).SetName("Sample Test"),
            new TestCaseData("10r5r0", new Point(0, 0)).SetName("Sample Test")
        };
    }
}