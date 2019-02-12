using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PooVueling.NunitV.Integration.Test
{
    [TestFixture]
    public class CalculadoraTest
    {
        readonly ICalculadora iCalculadora = new Calculadora();

        [TestCase(20, 11, 31)]
        public void Suma(int num1, int num2, int resultado)
        {
            Assert.AreEqual(31, iCalculadora.Suma(num1, num2));
        }

        [TestCase(32, 9, 23)]
        public void Resta(int num1, int num2, int resultado)
        {
            Assert.AreEqual(resultado, iCalculadora.Resta(num1, num2));
        }

        [TestCase(5, 5, 25)]
        public void Multiplicacion(int num1, int num2, int resultado)
        {
            Assert.AreEqual(resultado, iCalculadora.Multiplicacion(num1, num2));
        }

        [TestCase(80, 2, 40)]
        public void Division(int num1, int num2, int resultado)
        {
            Assert.AreEqual(resultado, iCalculadora.Division(num1, num2));
            Throws.TypeOf<DivideByZeroException>();
        }

        [TestCase(80, 0)]
        public void DivisionByZero(int num1, int num2)
        {
            Assert.That(() => iCalculadora.Division(num1, num2), Throws.TypeOf<DivideByZeroException>());
        }

    }
}
