using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu5.RGBToHexConversion;

public class RGBToHexConversionTests
{
      private RGBToHexConversion _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new RGBToHexConversion();
      }

      [Test]
      public void FixedTests() 
      {
          Assert.AreEqual("FFFFFF", _sut.RgbToHex(255,255,255));
          Assert.AreEqual("FFFFFF", _sut.RgbToHex(255,255,300));
          Assert.AreEqual("000000", _sut.RgbToHex(0,0,0));
          Assert.AreEqual("9400D3", _sut.RgbToHex(148,0,211));
          Assert.AreEqual("9400D3", _sut.RgbToHex(148,-20,211), "Handle negative numbers.");
          Assert.AreEqual("90C3D4", _sut.RgbToHex(144,195,212));
          Assert.AreEqual("D4350C", _sut.RgbToHex(212,53,12), "Consider single hex digit numbers.");
      }
}
