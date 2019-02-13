using Microsoft.VisualStudio.TestTools.UnitTesting;
using PooVueling;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowUnitTest
{
    [Binding]
    public class CalculatorSteps
    {
        private readonly Calculadora calculadora = new Calculadora();
        private int result;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculadora.FirstNumber = number;
        }
        
        [Given(@"I have also entered (.*) into the calculator")]
        public void GivenIHaveAlsoEnteredIntoTheCalculator(int number)
        {
            calculadora.SecondNumber = number;
        }
        
        [When(@"I press (.*)")]
        public void WhenIPressAction(string action)
        {
            switch (action)
            {
                case "add":
                    result = calculadora.Suma(calculadora.FirstNumber, calculadora.SecondNumber);
                    break;
                case "subtract":
                    result = calculadora.Resta(calculadora.FirstNumber, calculadora.SecondNumber);
                    break;
                case "multiply":
                    result = calculadora.Multiplicacion(calculadora.FirstNumber, calculadora.SecondNumber);
                    break;
                case "divide":
                    result = calculadora.Division(calculadora.FirstNumber, calculadora.SecondNumber);
                    break;
            }
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int expectedResult)
        {
            Assert.AreEqual(result, expectedResult);
        }
    }
}
