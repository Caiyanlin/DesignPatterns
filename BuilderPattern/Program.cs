using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            Builder abuilder = new BuilderA();
            Product product = director.Direct(abuilder);
            product.Show();
            Console.ReadKey();
        }
    }
}
