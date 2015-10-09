using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacotryPattern.FactoryMethod
{
    /// <summary>
    /// 抽象产品角色
    /// </summary>
    public interface IProduct
    {
        void Create();
    }

    /// <summary>
    /// 具体产品角色
    /// </summary>
    public class ConcreteProduct : IProduct
    {

        public void Create()
        {

        }
    }

    public class ConcreteAProduct : IProduct
    {

        public void Create()
        {

        }
    }

    /// <summary>
    /// 抽象工厂角色
    /// </summary>
    public interface Creator
    {
        IProduct FactoryMethod();
    }


    /// <summary>
    /// 具体工厂角色
    /// </summary>
    public class ConcreateCreator:Creator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }

    public class ConcreateACreator : Creator
    {
        public IProduct FactoryMethod()
        {
            return new ConcreteAProduct();
        }
    }
}
