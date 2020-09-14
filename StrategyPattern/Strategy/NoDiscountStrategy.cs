namespace StrategyPattern.Strategy
{
    internal class NoDiscountStrategy : IDiscountStrategy
    {
        public float GetDiscountPercentage()
        {
            return 0;
        }
    }
}