using NUnit.Framework;

namespace CSharpCodeWars.Kyu3.PathFinder3TheAlpinist;

public class PathFinder3TheAlpinistTests
{
      private PathFinder3TheAlpinist _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new PathFinder3TheAlpinist();
      }

      [Test]
      public void SampleTests()
      {

          string a = "000\n" +
                     "000\n" +
                     "000",

              b = "010\n" +
                  "010\n" +
                  "010",

              c = "010\n" +
                  "101\n" +
                  "010",

              d = "0707\n" +
                  "7070\n" +
                  "0707\n" +
                  "7070",

              e = "700000\n" +
                  "077770\n" +
                  "077770\n" +
                  "077770\n" +
                  "077770\n" +
                  "000007",

              f = "777000\n" +
                  "007000\n" +
                  "007000\n" +
                  "007000\n" +
                  "007000\n" +
                  "007777",

              g = "000000\n" +
                  "000000\n" +
                  "000000\n" +
                  "000010\n" +
                  "000109\n" +
                  "001010";

          Assert.AreEqual(0, _sut.PathFinder(a));
          Assert.AreEqual(2, _sut.PathFinder(b));
          Assert.AreEqual(4, _sut.PathFinder(c));
          Assert.AreEqual(42, _sut.PathFinder(d));
          Assert.AreEqual(14, _sut.PathFinder(e));
          Assert.AreEqual(0, _sut.PathFinder(f));
          Assert.AreEqual(4, _sut.PathFinder(g));
      }
      
      [Test]
      public void Test20By20()
      {
          var mazeAsString = 
              "00000000000000000000\n" +
              "00000000000000000000\n" +
              "00000000000000000000\n" +
              "00000000000000000100\n" +
              "00000000000000010999\n" +
              "00000000000000100900\n" +
              "00000000000000100900\n" +
              "00000000000000100900\n" +
              "00000000000000100900\n" +
              "00000000000000100900\n" +
              "00000000000000100900\n" +
              "00000000000000100900\n" +
              "00000000000000100900\n" +
              "00000000000000100900\n" +
              "00000000000000100900\n" +
              "00000000000000100900\n" +
              "00000000000000100900\n" +
              "00000000000000100900\n" +
              "00000000000000100900\n" +
              "00000000000000100900";
          
          Assert.AreEqual(18, _sut.PathFinder(mazeAsString));
      }

}
