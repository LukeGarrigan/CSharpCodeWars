using System.Text;
using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.GiveMeADiamond;

public class GiveMeADiamondTests
{
      private GiveMeADiamond _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new GiveMeADiamond();
      }

      [Test]
      public void TestDiamond1()
      {
          var expected = new StringBuilder();
          expected.Append("*\n");
          Assert.AreEqual(expected.ToString(), _sut.Print(1));
      }
      [Test]
      public void TestDiamond3()
      {
          var expected = new StringBuilder();
          expected.Append(" *\n");
          expected.Append("***\n"); // 1 = 2 / 2 
          expected.Append(" *\n");

          Assert.AreEqual(expected.ToString(), _sut.Print(3));
      }

      [Test]
      public void TestDiamond5()
      {
          var expected = new StringBuilder();
          expected.Append("  *\n");     // 2 = 4 / 2
          expected.Append(" ***\n");
          expected.Append("*****\n");
          expected.Append(" ***\n");
          expected.Append("  *\n");

          Console.WriteLine(expected.ToString());
          Assert.AreEqual(expected.ToString(), _sut.Print(5));
      }
}
