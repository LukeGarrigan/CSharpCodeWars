using NUnit.Framework;

namespace CSharpCodeWars.Kyu5.GreedIsGood;

public class GreedIsGoodTests
{
      private GreedIsGood _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new GreedIsGood();
      }

      [Test]
      public void ShouldBeWorthless()
      {
          Assert.AreEqual(0, _sut.Score(new int[] {2, 3, 4, 6, 2}), "Should be 0 :-(");
      }
  
      [Test]
      public void ShouldValueTriplets()
      {
          Assert.AreEqual(400, _sut.Score(new int[] {4, 4, 4, 3, 3}), "Should be 400");
      }
      
      [Test]
      public void ShouldCountIndividuals()
      {
          Assert.AreEqual(150, _sut.Score(new int[] {1, 4, 4, 5, 3}), "Should be 150");
      }
  
      [Test]
      public void ShouldValueMixedSets()
      {
          Assert.AreEqual(450, _sut.Score(new int[] {2, 4, 4, 5, 4}), "Should be 450");
      }
      

      [Test]
      public void ShouldCountWhen4OfOneType()
      {
          Assert.AreEqual(550, _sut.Score(new int[] {2, 5, 5, 5, 5}), "Should be 550");
      }
      
      [Test]
      public void ShouldCountWhen3_1sRolled()
      {
          Assert.AreEqual(1050, _sut.Score(new int[] {2, 1, 1, 1, 5}), "Should be 1050");
      }
}
