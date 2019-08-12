namespace Example.EnumToStrategyPattern
{
    public class Calculator
    {
        public MyTypes Type { get; set; }

        public decimal Number { get; set; }

        public decimal Calculate()
        {
            switch (Type)
            {
                case MyTypes.First:
                    return Number * 1;
                case MyTypes.Second:
                    return Number * 2;
                case MyTypes.Third:
                    return Number * 3;
                default:
                    return Number;
            }
        }
    }
}
