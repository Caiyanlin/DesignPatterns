using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    public class InsideClassB
    {
        public void Open()
        {
            Console.WriteLine("Open inside class B");
        }

        public void Close()
        {
            Console.WriteLine("Close inside class B");
        }
    }
}
