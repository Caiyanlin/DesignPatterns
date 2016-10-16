using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BridgePattern
{
    public abstract class Abstraction
    {
        Implementor _implementor = null;

        public  Abstraction(Implementor implementor)
        {
            _implementor = implementor;
        }
        public virtual void Operation()
        {
            _implementor.Operationimplement();
        }
    }
}
