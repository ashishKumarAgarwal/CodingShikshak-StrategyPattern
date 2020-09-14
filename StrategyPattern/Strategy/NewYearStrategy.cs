namespace StrategyPattern.Strategy
{
    internal class NewYearStrategy : IDiscountStrategy
    {
        public float GetDiscountPercentage()
        {
            return 10;
        }
    }
}