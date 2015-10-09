using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    public interface IDiscountStrategy
    {
        decimal ApplyExtraDiscount(decimal price);
    }


    public class TradeDiscountStrategy : IDiscountStrategy
    {
        public decimal ApplyExtraDiscount(decimal price)
        {
            return price * 0.8M;
        }

    }

    public class NullObjectDiscountStrategy : IDiscountStrategy
    {

        public decimal ApplyExtraDiscount(decimal price)
        {
            return price;
        }
    }
}
