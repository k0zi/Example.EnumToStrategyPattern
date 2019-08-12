namespace Example.EnumToStrategyPattern
{
    public class ThirdCalculator : ICalculator
    {
        public decimal Number { get; set; }

        public decimal Calculate()
        {
            return Number * 3;
        }

        public string GetTypeName()
        {
            return "Third";
        }
    }
}
