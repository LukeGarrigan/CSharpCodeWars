using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu4.PathFinder1CanYouReachTheExit;

public class PathFinder1CanYouReachTheExitTests
{
      private PathFinder1CanYouReachTheExit _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new PathFinder1CanYouReachTheExit();
      }

      [Test]
      public void sampleTests()
      {

          string a = ".W.\n" +
                     ".W.\n" +
                     "...",

              b = ".W.\n" +
                  ".W.\n" +
                  "W..",

              c = "......\n" +
                  "......\n" +
                  "......\n" +
                  "......\n" +
                  "......\n" +
                  "......",

              d = "......\n" +
                  "......\n" +
                  "......\n" +
                  "......\n" +
                  ".....W\n" +
                  "....W.";

          Assert.AreEqual(true, _sut.PathFinder(a));
          Assert.AreEqual(false, _sut.PathFinder(b));
          Assert.AreEqual(true, _sut.PathFinder(c));
          Assert.AreEqual(false, _sut.PathFinder(d));
      }
}
