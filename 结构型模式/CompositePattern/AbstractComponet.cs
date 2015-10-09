using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePattern
{
    /// <summary>
    /// 采用树形结构实现对象容器
    /// 把一对多的关系转化一对一的层次关系
    /// </summary>
    public abstract class AbstractComponet
    {
        private string _name;

        public AbstractComponet()
        {

        }

        public AbstractComponet(string name)
        {
            _name = name;
        }

        public string Name
        {
            get { return _name; }
        }

        public abstract AbstractComponet Add(AbstractComponet componet);
        public abstract void Remove(AbstractComponet componet);
        public abstract void Display(int depth);
    }
}
