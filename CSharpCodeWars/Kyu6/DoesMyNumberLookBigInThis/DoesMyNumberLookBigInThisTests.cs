using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.DoesMyNumberLookBigInThis;

public class DoesMyNumberLookBigInThisTests
{
      private DoesMyNumberLookBigInThis _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new DoesMyNumberLookBigInThis();
      }

      private static IEnumerable<TestCaseData> testCases
      {
          get
          {
              yield return new TestCaseData(1)
                  .Returns(true)
                  .SetDescription("1 is narcissitic");
              yield return new TestCaseData(153)
                  .Returns(true)
                  .SetDescription("153 is narcissitic");
              yield return new TestCaseData(371)
                  .Returns(true)
                  .SetDescription("371 is narcissitic");
              yield return new TestCaseData(154)
                  .Returns(false)
                  .SetDescription("154 is not narcissitic");
          }
      }
  
      [Test, TestCaseSource("testCases")]
      public bool Test(int n) => _sut.Narcissistic(n);
}
