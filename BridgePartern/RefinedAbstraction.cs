using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    public class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementor implementor) : base(implementor) { }
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("RefinedAbstraction Operation");
        }

    }
}
