using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    public class InsideClassA
    {
        public void Open()
        {
            Console.WriteLine("Open inside class A");
        }

        public void Close()
        {
            Console.WriteLine("Close inside class A");
        }
    }
}
