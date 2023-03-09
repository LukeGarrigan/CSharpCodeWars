using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.StopSnippingMyWords;

public class StopSnippingMyWordsTests
{
      private StopSnippingMyWords _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new StopSnippingMyWords();
      }

      [Test]
      public void Test1()
      {
          Assert.AreEqual("emocleW", _sut.SpinWords("Welcome"));
      }
  
      [Test]
      public void Test2()
      {  
          Assert.AreEqual("Hey wollef sroirraw", _sut.SpinWords("Hey fellow warriors"));
      }
  
      [Test]
      public void Test3()
      {
          Assert.AreEqual("This is a test", _sut.SpinWords("This is a test"));
      }
  
      [Test]
      public void Test4()
      {
          Assert.AreEqual("This is rehtona test", _sut.SpinWords("This is another test"));
      }
  
      [Test]
      public void Test5()
      {
          Assert.AreEqual("You are tsomla to the last test", _sut.SpinWords("You are almost to the last test"));
      }
  
      [Test]
      public void Test6()
      {
          Assert.AreEqual("Just gniddik ereht is llits one more", _sut.SpinWords("Just kidding there is still one more"));
      }
}
