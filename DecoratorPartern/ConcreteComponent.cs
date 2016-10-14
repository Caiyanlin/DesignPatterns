using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorPartern
{
    public class ConcreteComponent : Component
    {
        public void Operation()
        {
            Console.WriteLine("Old Behaviour"); 
        }
    }
}
