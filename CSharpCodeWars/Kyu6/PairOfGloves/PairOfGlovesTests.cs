using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.PairOfGloves;

public class PairOfGlovesTests
{
      private PairOfGloves _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new PairOfGloves();
      }

      [Test]
      public void Test1()
      {
          Assertion(0, new string[] {"Green", "Blue", "Purple", "Gray"});
          Assertion(0, new string[] {});
          Assertion(0, new string[] {"Purple"});
          
          Assertion(1, new string[] {"Blue", "Purple", "Blue", "Gray", "Lime", "Black"});
          Assertion(1, new string[] {"Blue", "Aqua", "Blue", "Teal", "Blue", "Black"});
          
          Assertion(2, new string[] {"Blue", "Aqua", "Blue", "Brown", "Blue", "Orange", "Aqua"});
      }
      
      private void Assertion(int expected, string[] input) =>
          Assert.AreEqual(
              expected,
              _sut.NumberOfPairs(input),
      
              $"Input: [{string.Join(", ", input)}]"
      
          );
}
