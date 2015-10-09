using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacotryPattern.SimpleFactory
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
    /// 工厂角色
    /// </summary>
    public class SimpleFactory
    {
        public static IProduct CreateProduct(string productName)
        {
            IProduct product = null;
            switch (productName)
            {
                case "ConcreateAProudct":
                    product = new ConcreteAProduct();
                    break;
                default:
                    product = new ConcreteProduct();
                    break;
            }

            return product;
             
        }
    }
}
