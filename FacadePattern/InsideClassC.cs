using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    public class InsideClassC
    {
        public void Open()
        {
            Console.WriteLine("Open inside class C");
        }

        public void Close()
        {
            Console.WriteLine("Close inside class C");
        }
    }
}
