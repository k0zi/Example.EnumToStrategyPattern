namespace Example.EnumToStrategyPattern
{
    public class SecondCalculator : ICalculator
    {
        public decimal Number { get; set; }

        public decimal Calculate()
        {
            return Number * 2;
        }

        public string GetTypeName()
        {
            return "Second";
        }
    }
}
