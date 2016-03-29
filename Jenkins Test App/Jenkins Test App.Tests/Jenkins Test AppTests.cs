using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenkins_Test_App.Tests
{
    [TestClass]
   public class Jenkins_Test_AppTests
    {
        [TestMethod]
        public void ShouldAddReturnNineWhenPassFiveandFour()
        {
            //Arrange
            Jenkins_Test_App sut = new Jenkins_Test_App();
            //Act
            int result = sut.Add(5, 4);
            //Asserrt
            Assert.AreEqual(9, result);
        }
        [TestMethod]
        public void ShouldMulReturnTwentyWhenPassFiveandFour()
        {
            //Arrange
            Jenkins_Test_App sut = new Jenkins_Test_App();
            //Act
            int result = sut.Mul(5, 4);
            //Asserrt
            Assert.AreEqual(20, result);
        }
    }
}
