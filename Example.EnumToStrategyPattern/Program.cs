using System;
using System.Linq;

namespace Example.EnumToStrategyPattern
{
    partial class Program
    {

        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                var number = 100;
                //var type = (MyTypes)Enum.Parse(typeof(MyTypes), args[0]);
                //var calculator = new Calculator() { Number = number, Type = type };
                var calculator = new CalculatorFactory(DummyDependencyContainer.GetCalculators()).GetCalculator(args[0]);
                calculator.Number = number;
                if(calculator.Calculate() == 100)
                {
                    Console.WriteLine("It's okay");
                }
                Console.ReadKey();
            }
        }
    }
}
