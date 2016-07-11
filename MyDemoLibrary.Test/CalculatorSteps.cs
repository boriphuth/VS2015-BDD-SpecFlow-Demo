using System;
using TechTalk.SpecFlow;

namespace MyDemoLibrary.Test
{
    [Binding]
    public class CalculatorSteps
    {
        private Calculator calculator = new Calculator();

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int number)
        {
            calculator.AddNumber(number);
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            calculator.DoCalculate();
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
