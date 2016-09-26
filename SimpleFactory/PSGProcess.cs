using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleFactory
{
    public class PSGProcess : Process
    {
        public override void Start()
        {
            Console.WriteLine("Start to do PSG Process");
        }
    }
}
