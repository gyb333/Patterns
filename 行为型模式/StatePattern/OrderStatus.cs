using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    public enum OrderStatus
    {
        New = 0,    //新订单
        Shipped =1, //已发货
        Canceled =2 //已取消
    }
}
