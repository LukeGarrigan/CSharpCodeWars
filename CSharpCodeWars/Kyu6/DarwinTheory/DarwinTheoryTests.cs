using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.DarwinTheory;

public class DarwinTheoryTests
{
      private Creature _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new Creature();
      }

      [Test]
      public void BasicTest()
      {
          Creature cat = new Creature();
          cat["Wing"] = false;
          Assert.IsFalse((bool)cat["Wing"]);
          cat["Leg"] = 4;
          Assert.AreEqual(4, cat["Leg"]);
          Assert.IsFalse((bool)cat["Wing"]);
          Creature human = new Creature();
          Assert.AreEqual(4, human["Leg"]);
          Assert.IsFalse((bool)human["Wing"]);
          cat["Leg"] = 2;
          Assert.AreEqual(2, human["Leg"]);
          Assert.IsFalse((bool)human["Wing"]);
      }
}
