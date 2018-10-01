using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MesOperationsArithmetiques;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestDivisionCasParDefaut()
        {
            Calculator calc = new Calculator();
            decimal resultat = calc.Diviser(4, 2);
            Assert.IsTrue(resultat == 2); // Une seule assertion par méthode, dans le principe
        }

        [TestMethod]
        public void TestDivisionDivisionParZero()
        {
            Calculator calc = new Calculator();
            Assert.ThrowsException<DivideByZeroException>(() => calc.Diviser(10,0));
        }
    }
}
