using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class IPGProcessManager : ProcessManager
    {
        public override Process Create()
        {
            return new IPGProcess();
        }
    }
}
