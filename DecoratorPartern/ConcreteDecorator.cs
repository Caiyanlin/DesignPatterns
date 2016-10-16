using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPattern
{
    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(Component _component) : base(_component) { }
        public override void Operation()
        {
            component.Operation();
            AddOperation();
        }

         void AddOperation()
        {
            Console.WriteLine("New Behaviour");
        }
    }
}
