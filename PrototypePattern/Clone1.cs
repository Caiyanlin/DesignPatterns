using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrototypePattern
{
    public class Clone1 : ProtoType
    {
        public override ProtoType Clone()
        {
            return this.MemberwiseClone() as ProtoType;
        }
    }
}
