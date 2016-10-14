using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPartern
{
    class Program
    {
        static void Main(string[] args)
        {
            Component component = new ConcreteComponent();
            ConcreteDecorator concreteDecorator = new ConcreteDecorator(component);
            concreteDecorator.Operation();
            Console.ReadKey();
        }
    }
}
