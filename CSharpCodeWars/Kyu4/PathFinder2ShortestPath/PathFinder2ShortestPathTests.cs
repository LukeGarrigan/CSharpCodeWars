using NUnit.Framework;

namespace CSharpCodeWars.Kyu4.PathFinder2ShortestPath;

public class PathFinder2ShortestPathTests
{
      private PathFinder2ShortestPath _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new PathFinder2ShortestPath();
      }

      [Test]
      public void TestBasic()
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
          //
          Assert.AreEqual(4, _sut.PathFinder(a));
          Assert.AreEqual(-1, _sut.PathFinder(b));
          Assert.AreEqual(10, _sut.PathFinder(c));
          Assert.AreEqual(-1, _sut.PathFinder(d));
      }
}
