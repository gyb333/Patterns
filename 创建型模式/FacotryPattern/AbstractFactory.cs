using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacotryPattern.AbstractFactory
{
    /// <summary>
    /// 抽象产品角色 显卡
    /// </summary>
    public interface IDisplayCard
    {
        
    }

    /// <summary>
    /// 抽象产品角色 显卡风扇
    /// </summary>
    public interface IDisplayFan
    {
       
    }

    /// <summary>
    /// 华硕显卡
    /// </summary>
    public class DisplayCardAsus : IDisplayCard
    {

    }

    /// <summary>
    /// 华硕显卡风扇
    /// </summary>
    public class DisplayFanAsus : IDisplayFan
    {

    }

    /// <summary>
    /// 抽象工厂接口
    /// </summary>
    public interface IDisplayFactory
    {
        IDisplayCard CreateDisplayCard();
        IDisplayFan CreateDisplayFan();
    }


    /// <summary>
    /// 具体工厂
    /// </summary>
    public class DisplayFactoryAsus : IDisplayFactory
    {

        public IDisplayCard CreateDisplayCard()
        {
            return new DisplayCardAsus();
        }

        public IDisplayFan CreateDisplayFan()
        {
            return new DisplayFanAsus();
        }
    }
}
