using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePartern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteImplementorA concreteImplementorA = new ConcreteImplementorA();
            Abstraction abstraction = new RefinedAbstraction(concreteImplementorA);
            abstraction.Operation();
            Console.ReadKey();
        }
    }
}
