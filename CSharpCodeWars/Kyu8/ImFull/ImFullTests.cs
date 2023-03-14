using NUnit.Framework;

namespace CSharpCodeWars.Kyu8.ImFull;

public class ImFullTests
{
      private ImFull _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new ImFull();
      }

      [Test]
      public static void InitTest()
      {
          Assert.AreEqual(new []{1, 0}, ImFull.MoveFood(new []{ 1, 0 }));
          Assert.AreEqual(new []{1, 1, 0, 0}, ImFull.MoveFood(new []{ 1, 0, 1, 0 }));
          Assert.AreEqual(new []{1, 1, 1, 1}, ImFull.MoveFood(new []{ 1, 1, 1, 1 }));
          Assert.AreEqual(new []{0, 0, 0, 0}, ImFull.MoveFood(new []{ 0, 0, 0, 0 }));
          Assert.AreEqual(new []{ 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0 }, ImFull.MoveFood(new []{ 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1}));
      }

      [Test]
      public void RandomTests()
      {
          for (int i = 0; i < 100; i++)
          {
              var input = Generate(i);
              
              var expected = input.Where(f => f == 1).Concat(input.Where(f => f == 0)).ToArray();
              Assert.AreEqual(expected, ImFull.MoveFood(input));
          }
      }
   
      public static int[] Generate(int size)
      {
          var rand = new Random();
          var result = new int[size];

          for (int i = 0; i < size; i++)
          {
              result[i] = rand.Next(2); // generate a random integer between 0 and 1
          }

          return result;
      }
}
