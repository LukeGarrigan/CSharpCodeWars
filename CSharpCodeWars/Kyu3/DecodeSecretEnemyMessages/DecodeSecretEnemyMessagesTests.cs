using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu3.DecodeSecretEnemyMessages;

public class DecodeSecretEnemyMessagesTests
{
      private DecodeSecretEnemyMessages _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new DecodeSecretEnemyMessages();
      }

      [Test]
      public void EncodeTests()
      {
          _sut.Encode("Hello World!").Should().Be("atC5kcOuKAr!");
      }
      
      [Test]
      public void ShouldBeCompatibleWithEncoder()
      {
          Assert.AreEqual("Hello World!", _sut.Decode(_sut.Encode("Hello World!")));
      }
}
