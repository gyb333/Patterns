using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public abstract class AbstractDecorator:IComponent
    {
        private IComponent _component;

        public void SetComponent(IComponent component)
        {
            _component = component;
        }



        public virtual void Operation()
        {
            if (_component != null)
                _component.Operation();
        }
    }
}
