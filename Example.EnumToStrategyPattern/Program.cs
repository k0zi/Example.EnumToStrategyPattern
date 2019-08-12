using System;

namespace Example.EnumToStrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                var type = (MyTypes)Enum.Parse(typeof(MyTypes), args[0]);
                var number = 100;
                var calculator = new Calculator() { Number = number, Type = type };
            }
            
        }
    }
}
