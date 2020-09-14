using StrategyPattern.Model;
using StrategyPattern.Strategy;

namespace StrategyPattern.Context
{
    internal class ItemContext
    {
        private readonly IDiscountStrategy _discountStrategy;

        public ItemContext(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public float GetItemNetPrice(Item item)

        {
            return item.Price - (item.Price * _discountStrategy.GetDiscountPercentage() / 100);
        }
    }
}