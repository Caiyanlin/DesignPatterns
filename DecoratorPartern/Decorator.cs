using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Decorator : Component
    {
       protected Component component = null;

       public Decorator(Component _component)
       {
           component = _component;
       }
       public virtual void Operation()
        {
            component.Operation();
        }
    }
}
