using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public class Order
    {
        private IOrderState _orderState;

        public Order(IOrderState orderState)
        {
            _orderState = orderState;
        }

        public int Id { get; set; }
        public string Customer { get; set; }
        public DateTime OrderedDate { get; set; }
        public OrderStatus Status()
        {
            return _orderState.Status;
        }

        public bool CanCanCel()
        {
            return _orderState.CanCancel(this);
        }

        public void CanCel()
        {
            if (CanCanCel())
                _orderState.Cancel(this);
        }

        public bool CanShip()
        {
            return _orderState.CanShip(this);
        }

        public void Ship()
        {
            if (CanShip())
                _orderState.Ship(this);
        }

        internal  void Change(IOrderState orderState)
        {
            _orderState = orderState;
        }
    }
}
