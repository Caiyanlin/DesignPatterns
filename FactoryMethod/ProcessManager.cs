using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public abstract class ProcessManager
    {
        public abstract Process Create();

    }
}
