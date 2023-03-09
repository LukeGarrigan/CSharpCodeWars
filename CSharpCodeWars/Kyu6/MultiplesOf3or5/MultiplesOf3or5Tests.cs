using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.MultiplesOf3or5;

public class MultiplesOf3or5Tests
{
      private MultiplesOf3or5 _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new MultiplesOf3or5();
      }

      [Test]
      public void Test()
      {
          Assert.AreEqual(23, _sut.Solution(10));
      }
}
