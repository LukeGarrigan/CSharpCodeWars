using NUnit.Framework;

namespace CSharpCodeWars.Kyu7.SumListIgnoreDups;

public class SumListIgnoreDupsTests
{
      private SumListIgnoreDups _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new SumListIgnoreDups();
      }

      [Test]
      public void Test1()
      {
          Assert.AreEqual(5, _sut.SumNoDuplicates(new int[]{1,1,2,3}));
          Assert.AreEqual(3, _sut.SumNoDuplicates(new int[]{1,1,2,2,3}));
      }
}
