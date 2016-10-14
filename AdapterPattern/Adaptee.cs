using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    public abstract class Adaptee
    {
        public void SpecificRequest()
        {
            Console.WriteLine("This is class adapter");
        }
    }
}
