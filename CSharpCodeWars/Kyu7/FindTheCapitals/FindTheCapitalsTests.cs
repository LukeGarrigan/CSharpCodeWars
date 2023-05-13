using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu7.FindTheCapitals;

public class FindTheCapitalsTests
{
      private FindTheCapitals _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new FindTheCapitals();
      }

      [Test]
      public void CodEWaRs()
      {
          Assert.AreEqual(_sut.Capitals("CodEWaRs"), new int[]{0,3,4,6});
      }
}
