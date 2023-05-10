using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.MexicanWave;

public class MexicanWaveTests
{
      private MexicanWave _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new MexicanWave();
      }
      [TestCase]
      public void BasicTest1()
      {
          List<string> result = new List<string> { "Hello", "hEllo", "heLlo", "helLo", "hellO" };
          Assert.AreEqual(result, _sut.Wave("hello"), "it should return '"+result+"'");
      }

      [TestCase]
      public void BasicTest2()
      {
          List<string> result = new List<string> { "Codewars", "cOdewars", "coDewars", "codEwars", "codeWars", "codewArs", "codewaRs", "codewarS" };
          Assert.AreEqual(result, _sut.Wave("codewars"), "it should return '" + result + "'");
      }

      [TestCase]
      public void BasicTest3()
      {
          List<string> result = new List<string> { };
          Assert.AreEqual(result, _sut.Wave(""), "it should return '" + result + "'");
      }

      [TestCase]
      public void BasicTest4()
      {
          List<string> result = new List<string> { "Two words", "tWo words", "twO words", "two Words", "two wOrds", "two woRds", "two worDs", "two wordS" };
          Assert.AreEqual(result, _sut.Wave("two words"), "it should return '" + result + "'");
      }

      [TestCase]
      public void BasicTest5()
      {
          List<string> result = new List<string> { " Gap ", " gAp ", " gaP " };
          Assert.AreEqual(result, _sut.Wave(" gap "), "it should return '" + result + "'");
      }
}
