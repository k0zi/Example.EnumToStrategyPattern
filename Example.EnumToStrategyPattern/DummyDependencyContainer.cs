using System.Collections.Generic;

namespace Example.EnumToStrategyPattern
{
    partial class Program
    {
        internal class DummyDependencyContainer
        {
            internal static IEnumerable<ICalculator> GetCalculators()
            {
                yield return new FirstCalculator();
                yield return new SecondCalculator();
                yield return new ThirdCalculator();
            }
        }
    }
}
