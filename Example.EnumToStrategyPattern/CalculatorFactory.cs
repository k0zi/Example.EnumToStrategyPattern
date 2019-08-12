using System;
using System.Collections.Generic;

namespace Example.EnumToStrategyPattern
{
    public class CalculatorFactory
    {
        private readonly IEnumerable<ICalculator> calculators;
        public CalculatorFactory(IEnumerable<ICalculator> calculators)
        {
            this.calculators = calculators;
        }
        public ICalculator GetCalculator(string type)
        {
            return calculators.First(c => c.GetTypeName().Equals(type, StringComparison.InvariantCultureIgnoreCase));
        }
    }
}
