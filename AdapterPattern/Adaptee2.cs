using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdapterPattern
{
    public class Adaptee2
    {
        public void SpecificRequest()
        {
            Console.WriteLine("This is instance adapter");
        }
    }
}
