using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePartern
{
    public class ConcreteImplementorA : Implementor
    {
        public override void Operationimplement()
        {
            Console.WriteLine("Concrete Implementor A implement operation");
        }
    }
}
