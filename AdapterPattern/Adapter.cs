using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    public class Adapter : Adaptee, ITarget
    {
        public Adaptee2 adp2 = new Adaptee2();
        public void Request()
        {
            this.SpecificRequest();

            adp2.SpecificRequest();
        }
    }
}
