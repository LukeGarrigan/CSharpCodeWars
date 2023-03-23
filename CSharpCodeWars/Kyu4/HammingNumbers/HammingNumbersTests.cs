using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu4.HammingNumbers;

public class HammingNumbersTests
{
      private HammingNumbers _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new HammingNumbers();
      }

      [Test]
      public void Test1() {
          Assert.AreEqual(1, _sut.Hamming(1), "Hamming(1) should be 1");
          Assert.AreEqual(2, _sut.Hamming(2), "Hamming(2) should be 2");
          Assert.AreEqual(3, _sut.Hamming(3), "Hamming(3) should be 3");
          Assert.AreEqual(4, _sut.Hamming(4), "Hamming(4) should be 4");
          Assert.AreEqual(5, _sut.Hamming(5), "Hamming(5) should be 5");
          Assert.AreEqual(6, _sut.Hamming(6), "Hamming(6) should be 6");
          Assert.AreEqual(8, _sut.Hamming(7), "Hamming(7) should be 8");
          Assert.AreEqual(9, _sut.Hamming(8), "Hamming(8) should be 9");
          Assert.AreEqual(10, _sut.Hamming(9), "Hamming(9) should be 10");
          Assert.AreEqual(12, _sut.Hamming(10), "Hamming(10) should be 12");
          Assert.AreEqual(15, _sut.Hamming(11), "Hamming(11) should be 15");
          Assert.AreEqual(16, _sut.Hamming(12), "Hamming(12) should be 16");
          Assert.AreEqual(18, _sut.Hamming(13), "Hamming(13) should be 18");
          Assert.AreEqual(20, _sut.Hamming(14), "Hamming(14) should be 20");
          Assert.AreEqual(24, _sut.Hamming(15), "Hamming(15) should be 24");
          Assert.AreEqual(25, _sut.Hamming(16), "Hamming(16) should be 25");
          Assert.AreEqual(27, _sut.Hamming(17), "Hamming(17) should be 27");
          Assert.AreEqual(30, _sut.Hamming(18), "Hamming(18) should be 30");
          Assert.AreEqual(32, _sut.Hamming(19), "Hamming(19) should be 32");
      }
}
