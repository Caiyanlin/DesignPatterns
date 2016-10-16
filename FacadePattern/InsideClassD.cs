using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacadePattern
{
    public class InsideClassD
    {
        public void Open()
        {
            Console.WriteLine("Open inside class D");
        }

        public void Close()
        {
            Console.WriteLine("Close inside class D");
        }
    }
}
