using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace unitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodOkayEmm()
        {
            //Arrange
            GestioProcessos.Processat_Final controller = new GestioProcessos.Processat_Final();

            // Act
            bool test = controller.comprobarEspectograf(new string[]{ "25", "70", "2"});

            // Assert
            Assert.IsTrue(test);
        }
        [TestMethod]
        public void TestMethodOkay()
        {
            //Arrange
            GestioProcessos.Emmagatzematge controller = new GestioProcessos.Emmagatzematge();

            // Act
            string test = controller.obtenirHoraCorrecta("16");

            // Assert
            Assert.AreEqual("15", test);
        }
        [TestMethod]
        public void TestMethodWrong()
        {
            //Arrange
            GestioProcessos.Emmagatzematge controller = new GestioProcessos.Emmagatzematge();

            // Act
            string test = controller.obtenirHoraCorrecta("16");

            // Assert
            Assert.AreNotEqual("30", test);
        }
        [TestMethod]
        public void TestMethodOkay2()
        {
            //Arrange
            GestioProcessos.Emmagatzematge controller = new GestioProcessos.Emmagatzematge();

            // Act
            string test = controller.obtenirHoraCorrecta("35");

            // Assert
            Assert.AreEqual("30", test);
        }
    }
}
