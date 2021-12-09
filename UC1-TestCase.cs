using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MSTesting

    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestAddition()
        {
            //AAA Methodology
            //Arrange
            int numb1 = 10;
            int numb2 = 20;
            int expected = 30;

            //Act
            //MathematicOperations operations = new MathematicOperations();
            int actual=operations.Addition(numb1,numb2);

            //Assert
            Assert.AreEqual(expected,actual);
        }
    }
}
