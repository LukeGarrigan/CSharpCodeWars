using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu8.KeepHydrated;

public class KeepHydratedTests
{
      private KeepHydrated _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new KeepHydrated();
      }

      [Test]
      public void Test1()
      {
          Assert.AreEqual(1, _sut.Litres(2));
      }
  
      [Test]
      public void Test2()
      {  
          Assert.AreEqual(0, _sut.Litres(1.4));
      }
  
      [Test]
      public void Test3()
      {
          Assert.AreEqual(6, _sut.Litres(12.3));
      }
  
      [Test]
      public void Test4()
      {
          Assert.AreEqual(0, _sut.Litres(0.82));
      }
  
      [Test]
      public void Test5()
      {
          Assert.AreEqual(5, _sut.Litres(11.8));
      }
  
      [Test]
      public void Test6()
      {
          Assert.AreEqual(893, _sut.Litres(1787));
      }
      [Test]
      public void Test7()
      {
          Assert.AreEqual(0, _sut.Litres(0));
      }

}
