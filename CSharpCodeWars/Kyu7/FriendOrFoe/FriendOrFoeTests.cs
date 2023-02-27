using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu7.FriendOrFoe;

public class FriendOrFoeTests
{
      private FriendOrFoe _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new FriendOrFoe();
      }

      [Test]
      public void Test1 () {
          string[] expected = { "Ryan", "Mark" };
          string[] names = { "Ryan", "Kieran", "Mark", "Jimmy" };
          CollectionAssert.AreEqual (expected, _sut.IsFriendOrFoe(names));
      }
}
