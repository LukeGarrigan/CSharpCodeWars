using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu5.Int32ToIPv4;

public class Int32ToIPv4Tests
{
      private Int32ToIPv4 _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new Int32ToIPv4();
      }

      [Test, Description("Sample Tests")]
      public void Test()
      {
          Assert.AreEqual("128.114.17.104", _sut.ToIPv4(2154959208));
          Assert.AreEqual("0.0.0.32", _sut.ToIPv4(32));
          Assert.AreEqual("0.0.0.0", _sut.ToIPv4(0));
          Assert.AreEqual("128.32.10.1", _sut.ToIPv4(2149583361));
      }
}
