using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StrategyPattern
{
    /// <summary>
    /// 使算法责任和算法本身分开，委派给上下文对象管理。
    /// 多种行为在子类里不断的改变且在运行时确定
    /// </summary>
    public class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ContextAlgorithm()
        {
            _strategy.Algorithm();
        }
    }
}
