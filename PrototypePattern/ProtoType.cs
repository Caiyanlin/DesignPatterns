using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    public abstract class ProtoType
    {
        public abstract ProtoType Clone();
    }
}
