using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.YourOrderPlease;

public class YourOrderPleaseTests
{
      private YourOrderPlease _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new YourOrderPlease();
      }

      [Test, Description("Sample Tests")]
      public void SampleTest()
      {
          Assert.AreEqual("Thi1s is2 3a T4est", _sut.Order("is2 Thi1s T4est 3a"));
          Assert.AreEqual("Fo1r the2 g3ood 4of th5e pe6ople", _sut.Order("4of Fo1r pe6ople g3ood th5e the2"));
          Assert.AreEqual("", _sut.Order(""));
      }
}
