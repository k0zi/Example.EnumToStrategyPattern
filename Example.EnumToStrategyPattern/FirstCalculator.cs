namespace Example.EnumToStrategyPattern
{
    public class FirstCalculator : ICalculator
    {
        public decimal Number { get; set; }

        public decimal Calculate()
        {
            return Number * 1;
        }

        public string GetTypeName()
        {
            return "First";
        }
    }
}
