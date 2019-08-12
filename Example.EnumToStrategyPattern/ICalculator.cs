namespace Example.EnumToStrategyPattern
{
    public interface ICalculator
    {
        decimal Number { get; set; }

        decimal Calculate();

        string GetTypeName();
    }
}