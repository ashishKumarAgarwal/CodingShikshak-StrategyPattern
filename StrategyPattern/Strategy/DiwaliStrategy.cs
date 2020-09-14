namespace StrategyPattern.Strategy
{
    internal class DiwaliStrategy : IDiscountStrategy
    {
        public float GetDiscountPercentage()
        {
            return 20;
        }
    }
}