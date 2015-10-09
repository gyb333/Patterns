using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatePattern
{
    /// <summary>
    /// 用于独立于其他行为的对象状态
    /// 允许对象在其内部状态变化时改变自己的行为，通过切换实现状态依赖行为的内部状态对象实现
    /// 对象将所有基于状态的行为推给依赖的状态子类
    /// 减轻对象方法中Case语句的需求量
    /// </summary>
    public interface IOrderState
    {
        //发货
        bool CanShip(Order order);
        void Ship(Order order);

        //取消
        bool CanCancel(Order order);
        void Cancel(Order order);

        OrderStatus Status { get; }
    }
}
