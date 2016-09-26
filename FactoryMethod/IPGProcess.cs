using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FactoryMethod
{
    public class IPGProcess : Process
    {
        public override void Start()
        {
            Console.WriteLine("Start IPG Process");
        }
    }
}
