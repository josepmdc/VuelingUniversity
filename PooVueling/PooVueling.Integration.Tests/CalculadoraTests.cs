using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooVueling.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        ICalculadora iCalculadora = new Calculadora();
        
        [DataRow(2, 2, 1)]
        [DataRow(50, 2, 25)]
        [DataTestMethod]
        public void DivisionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1, num2) == resultado);
        }
        
        [DataRow(10, 0, 5)]
        [DataTestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionTestException(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Division(num1, num2) == resultado);
        }

        [DataRow(2, 2, 4)]
        [DataRow(10, 2, 20)]
        [DataRow(50, 2, 100)]
        [DataTestMethod]
        public void MultiplicacionTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Multiplicacion(num1, num2) == resultado);
        }

        [DataRow(2, 2, 0)]
        [DataRow(10, 2, 8)]
        [DataRow(50, 2, 48)]
        [DataTestMethod]
        public void RestaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Resta(num1, num2) == resultado);
        }

        [DataRow(2, 2, 4)]
        [DataRow(10, 2, 12)]
        [DataRow(50, 2, 52)]
        [DataTestMethod]
        public void SumaTest(int num1, int num2, int resultado)
        {
            Assert.IsTrue(iCalculadora.Suma(num1, num2) == resultado);
        }
    }
}