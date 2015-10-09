using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SpecificationPattern
{
    /// <summary>
    /// 组合模式的一种扩展
    /// 规格模式：把业务逻辑封装到业务实体之外
    /// 业务规则不适于放到已有的实体或值对象中
    /// 规格是值对象，用来判断对象是否满足标准的谓词(计算结果为bool的函数)
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ISpecification<T>
    {
        bool isSatisfiedBy(T candidate);

        ISpecification<T> And(ISpecification<T> other);

        ISpecification<T> Or(ISpecification<T> other);

        ISpecification<T> Not();
    }
}
