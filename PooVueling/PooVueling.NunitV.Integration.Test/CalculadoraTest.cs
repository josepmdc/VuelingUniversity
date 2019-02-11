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
        ICalculadora iCalculadora = new Calculadora();

        [TestCase]
        public void Suma()
        {
            Assert.AreEqual(31, iCalculadora.Suma(20, 11));
        }

        [TestCase]
        public void Resta()
        {
            Assert.AreEqual(23, iCalculadora.Resta(32, 9));
        }

        [TestCase]
        public void Multiplicacion()
        {
            Assert.AreEqual(25, iCalculadora.Multiplicacion(5, 5));
        }

        [TestCase]
        public void Division()
        {
            Assert.AreEqual(40, iCalculadora.Division(80, 2));
        }


    }
}
