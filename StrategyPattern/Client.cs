using StrategyPattern.Context;
using StrategyPattern.Model;
using StrategyPattern.Strategy;
using System;

namespace StrategyPattern
{
    internal class Client
    {
        private static void Main(string[] args)
        {
            Item item = new Item { Name = "Smartphone", Price = 50000 };
            ItemContext context = new ItemContext(new NewYearStrategy());
            Console.WriteLine($"Price of {item.Name} = {context.GetItemNetPrice(item)}");
            Console.ReadLine();
        }
    }
}