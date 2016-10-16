using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            Console.WriteLine("Open all class");
            facade.open();
            Console.WriteLine("Close all class");
            facade.Close();
            Console.ReadKey();
        }
    }
}
