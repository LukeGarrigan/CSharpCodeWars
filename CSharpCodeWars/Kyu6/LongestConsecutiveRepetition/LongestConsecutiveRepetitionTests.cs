using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.LongestConsecutiveRepetition;

public class LongestConsecutiveRepetitionTests
{
      private LongestConsecutiveRepetition _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new LongestConsecutiveRepetition();
      }

      [Test]
      public void LongestAtTheBeginning()
      {
          Assert.AreEqual(new Tuple<char?, int> ('a', 4), _sut.LongestRepetition("aaaabb"));
          Assert.AreEqual(new Tuple<char?, int> ('b', 5), _sut.LongestRepetition("abbbbb"));
      }
    
      [Test]
      public void LongestAtTheEnd()
      {
          Assert.AreEqual(new Tuple<char?, int> ('a', 4), _sut.LongestRepetition("bbbaaabaaaa"));
      }
    
      [Test]
      public void LongestInTheMiddle()
      {
          Assert.AreEqual(new Tuple<char?, int> ('u', 3), _sut.LongestRepetition("cbdeuuu900"));
      }
    
      [Test]
      public void MultipleLongest()
      {
          Assert.AreEqual(new Tuple<char?, int> ('a', 2), _sut.LongestRepetition("aabb"));
          Assert.AreEqual(new Tuple<char?, int> ('b', 1), _sut.LongestRepetition("ba"));
      }
    
      [Test]
      public void EmptyString()
      {
          Assert.AreEqual(new Tuple<char?, int> (null, 0),  _sut.LongestRepetition(""));      
      }  
}
