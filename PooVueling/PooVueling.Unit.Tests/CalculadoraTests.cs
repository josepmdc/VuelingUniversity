using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;

namespace PooVueling.Unit.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {

        private ICalculadora mockObject;

        [TestInitialize]
        public void Setup()
        {
            var mock = new Mock<ICalculadora>();
            mock.Setup(x => x.Suma(2, 2)).Returns(4);
            mock.Setup(x => x.Resta(4, 2)).Returns(2);
            mock.Setup(x => x.Division(4, 2)).Returns(2);
            mock.Setup(x => x.Division(4, 0)).Throws<DivideByZeroException>();
            mock.Setup(x => x.Multiplicacion(4, 2)).Returns(8);
            mockObject = mock.Object;
        }
        
        [TestMethod()]
        public void DivisionTest()
        {
            var result = mockObject.Division(4, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        [ExpectedException(typeof(DivideByZeroException))]
        public void DivisionByZeroTest()
        {
            var result = mockObject.Division(4, 0);
        }

        [TestMethod()]
        public void MultiplicacionTest()
        {
            var result = mockObject.Multiplicacion(4, 2);
            Assert.AreEqual(8, result);
        }

        [TestMethod()]
        public void RestaTest()
        {
            var result = mockObject.Resta(4, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod()]
        public void SumaTest()
        {
            var result = mockObject.Suma(2, 2);
            Assert.AreEqual(4, result);
        }
    }
}