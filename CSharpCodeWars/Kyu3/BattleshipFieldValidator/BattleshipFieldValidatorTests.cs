using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu3.BattleshipFieldValidator;

public class BattleshipFieldValidatorTests
{
      private BattleshipFieldValidator _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new BattleshipFieldValidator();
      }

      [Test]
      public void TestCase() {
          int[,] field = new int[10,10]
             {{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
              {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
              {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
              {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
              {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
              {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
              {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
              {0, 0, 0, 1, 0, 0, 0, 0, 0, 0},
              {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
              {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
          Assert.IsTrue(_sut.ValidateBattleField(field));
      }
      
      [Test]
      public void ReturnFalseIfInContact() {
          int[,] field = new int[10,10]
          {{1, 0, 0, 0, 0, 1, 1, 0, 0, 0},
              {1, 0, 1, 0, 0, 0, 0, 0, 1, 0},
              {1, 0, 1, 0, 1, 1, 1, 0, 1, 0},
              {1, 0, 0, 0, 0, 0, 0, 0, 0, 0},
              {0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
              {0, 0, 0, 0, 1, 1, 1, 0, 0, 0},
              {0, 0, 0, 1, 0, 0, 0, 0, 1, 0},
              {0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
              {0, 0, 0, 0, 0, 0, 0, 1, 0, 0},
              {0, 0, 0, 0, 0, 0, 0, 0, 0, 0}};
          Assert.IsFalse(_sut.ValidateBattleField(field));
      }
}
