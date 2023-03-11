using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu8.CountTheLikes;

public class CountTheLikesTests
{
      private CountTheLikes _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new CountTheLikes();
      }
      [Test]
      public void Test1() {
          Assert.AreEqual(true, _sut.EvalLikes(new string[] {"today","was","so","like","awesome"}));
      }
  
      [Test]
      public void Test2() {
          Assert.AreEqual(false, _sut.EvalLikes(new string[] {"yesterday","was","even","ummm","better"}));
      }
      
      [Test]
      public void Test3() {
          Assert.AreEqual(false, _sut.EvalLikes(new string[] {"today","was","so","like","awesome", "yesterday","was","even","ummm","better", "yesterday","was","even","ummm","better", "yesterday","was","even","ummm","better", "yesterday","was","even","ummm","better"}));
      }
}
