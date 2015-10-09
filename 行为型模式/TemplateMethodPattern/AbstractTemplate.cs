using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TemplateMethodPattern
{
    //对于某一个业务逻辑在不同的对象中有不同的细节实现，但是逻辑算法的流程是相同的。
    //采用继承方式将变化的具体步骤延迟到子类中，却不改变一个算法的结构
    /// <summary>
    /// 抽象模版
    /// </summary>
    public abstract class AbstractTemplatePhone
    {
        /// <summary>
        /// 抽象业务流程行为
        /// </summary>
        public abstract void BuildMb();
        public abstract void BuildCpu();
        public abstract void SetSystem();

        /// <summary>
        /// 具体流程逻辑架构
        /// </summary>
        public void TemplateMethod()
        {
            BuildMb();
            BuildCpu();
            SetSystem();
        }
    }

   

}
