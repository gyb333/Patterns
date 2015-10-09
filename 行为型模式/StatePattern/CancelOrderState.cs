using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public class CancelOrderState:IOrderState
    {
        public bool CanShip(Order order)
        {
            return false;
        }

        public void Ship(Order order)
        {
            throw new NotImplementedException("You can't ship a canceled order! ");
        }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public void Cancel(Order order)
        {
            throw new NotImplementedException("this order is already cancelled!");
        }

        public OrderStatus Status
        {
            get { return OrderStatus.Canceled; }
        }
    }
}
