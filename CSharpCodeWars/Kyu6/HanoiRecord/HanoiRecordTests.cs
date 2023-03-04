using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu6.HanoiRecord;

public class HanoiRecordTests
{
      private HanoiRecord _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new HanoiRecord();
      }

      [TestCase(1, 1)]
      [TestCase(2, 3)]
      [TestCase(3, 7)]
      [TestCase(5, 31)]
      [TestCase(10, 1023)]
      [TestCase(20, 1048575)]
      public void SampleTests(int disks, int expected)
      {
          var actual = _sut.Hanoi(disks);
          Assert.AreEqual(expected, actual, $"For disks: {disks}");
      }
}
