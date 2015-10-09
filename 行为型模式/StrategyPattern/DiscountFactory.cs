using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public enum CustomerType
    {
        Standard = 0,
        Trade = 1
    }
    public static class DiscountFactory
    {
        public static IDiscountStrategy GetDiscountStrategy(CustomerType  customerType)
        {
            switch (customerType)
            {
                case CustomerType.Trade:
                    return new TradeDiscountStrategy();
                default:
                    return new NullObjectDiscountStrategy();
            }
        }
    }
}
