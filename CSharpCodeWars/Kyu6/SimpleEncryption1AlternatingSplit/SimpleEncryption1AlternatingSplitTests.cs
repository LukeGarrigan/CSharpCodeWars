using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.SimpleEncryption1AlternatingSplit;

public class SimpleEncryption1AlternatingSplitTests
{
      private SimpleEncryption1AlternatingSplit _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new SimpleEncryption1AlternatingSplit();
      }

       [Test]
        public void EncryptExampleTests()
        {
          Assert.AreEqual("135024", _sut.Encrypt("012345", 1));
          Assert.AreEqual("This is a test!", _sut.Encrypt("This is a test!", 0));
          Assert.AreEqual("hsi  etTi sats!", _sut.Encrypt("This is a test!", 1));
          Assert.AreEqual("s eT ashi tist!", _sut.Encrypt("This is a test!", 2));
          Assert.AreEqual(" Tah itse sits!", _sut.Encrypt("This is a test!", 3));
          Assert.AreEqual("This is a test!", _sut.Encrypt("This is a test!", 4));
          Assert.AreEqual("This is a test!", _sut.Encrypt("This is a test!", -1));
          Assert.AreEqual("hskt svr neetn!Ti aai eyitrsig", _sut.Encrypt("This kata is very interesting!", 1));
        }
        
        [Test]
        public void DecryptExampleTests()
        {
          Assert.AreEqual("012345", _sut.Decrypt("135024", 1));
          Assert.AreEqual("This is a test!", _sut.Decrypt("This is a test!", 0));
          Assert.AreEqual("This is a test!", _sut.Decrypt("hsi  etTi sats!", 1));
          Assert.AreEqual("This is a test!", _sut.Decrypt("s eT ashi tist!", 2));
          Assert.AreEqual("This is a test!", _sut.Decrypt(" Tah itse sits!", 3));
          Assert.AreEqual("This is a test!", _sut.Decrypt("This is a test!", 4));
          Assert.AreEqual("This is a test!", _sut.Decrypt("This is a test!", -1));
          //Assert.AreEqual("This _sut is very interesting!", _sut.Decrypt("hskt svr neetn!Ti aai eyitrsig", 1));
        }
        
        [Test]
        public void EmptyTests()
        {
          Assert.AreEqual("", _sut.Encrypt("", 0));
          Assert.AreEqual("", _sut.Decrypt("", 0));
        }
        
        [Test]
        public void NullTests()
        {
          Assert.AreEqual(null, _sut.Encrypt(null, 0));
          Assert.AreEqual(null, _sut.Decrypt(null, 0));
        }
}
