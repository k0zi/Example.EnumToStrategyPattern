using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Example.EnumToStrategyPattern.Tests
{
    [TestClass]
    public class CalculatorTests
    {
        private Calculator CreateCalculator(decimal number, MyTypes type)
        {
            return new Calculator() { Number = number, Type = type };
        }
        [TestMethod]
        public void Calculate_First_100()
        {
            var calculator = CreateCalculator(100, MyTypes.First);
            var result = calculator.Calculate();
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void Calculate_Second_200()
        {
            var calculator = CreateCalculator(100, MyTypes.Second);
            var result = calculator.Calculate();
            Assert.AreEqual(200, result);
        }

        [TestMethod]
        public void Calculate_Third_300()
        {
            var calculator = CreateCalculator(100, MyTypes.Third);
            var result = calculator.Calculate();
            Assert.AreEqual(300, result);
        }
    }
}
