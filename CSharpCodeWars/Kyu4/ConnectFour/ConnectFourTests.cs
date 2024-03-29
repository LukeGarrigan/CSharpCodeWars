using NUnit.Framework;
using FluentAssertions;

namespace CSharpCodeWars.Kyu4.ConnectFour;

public class ConnectFourTests
{
      private ConnectFour _sut;
      
      [SetUp]
      public void Setup()
      {
          _sut = new ConnectFour();
      }

        [Test]
        public void FirstTest()
        {
            List<string> myList = new List<string>()
            {
                "A_Red",
                "B_Yellow",
                "A_Red",
                "B_Yellow",
                "A_Red",
                "B_Yellow",
                "G_Red",
                "B_Yellow"
            };
            StringAssert.AreEqualIgnoringCase("Yellow",_sut.WhoIsWinner(myList),"it should return Yellow");
        }

        [Test]
        public void SecondTest()
        {
            List<string> myList = new List<string>()
            {
                "C_Yellow",
                "E_Red",
                "G_Yellow",
                "B_Red",
                "D_Yellow",
                "B_Red",
                "B_Yellow",
                "G_Red",
                "C_Yellow",
                "C_Red",
                "D_Yellow",
                "F_Red",
                "E_Yellow",
                "A_Red",
                "A_Yellow",
                "G_Red",
                "A_Yellow",
                "F_Red",
                "F_Yellow",
                "D_Red",
                "B_Yellow",
                "E_Red",
                "D_Yellow",
                "A_Red",
                "G_Yellow",
                "D_Red",
                "D_Yellow",
                "C_Red"
            };
            StringAssert.AreEqualIgnoringCase("Yellow",_sut.WhoIsWinner(myList));
        }
        
        [Test]
        public void ThirdTest()
        {
            List<string> myList = new List<string>()
            {
                "A_Yellow",
                "B_Red",
                "B_Yellow",
                "C_Red",
                "G_Yellow",
                "C_Red",
                "C_Yellow",
                "D_Red",
                "G_Yellow",
                "D_Red",
                "G_Yellow",
                "D_Red",
                "F_Yellow",
                "E_Red",
                "D_Yellow"
            };
            StringAssert.AreEqualIgnoringCase("Red",_sut.WhoIsWinner(myList),"it should return Red");
        }
}
