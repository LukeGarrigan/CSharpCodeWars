using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu8.GrassHoperPersonalisedMessage;

public class GrassHoperPersonalisedMessageTests
{
      private GrassHoperPersonalisedMessage _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new GrassHoperPersonalisedMessage();
      }
      [Test]
      public void MyTest()
      {
          Assert.AreEqual("Hello boss", _sut.Greet("Daniel", "Daniel"));
          Assert.AreEqual("Hello guest", _sut.Greet("Greg", "Daniel"));
      }
}
