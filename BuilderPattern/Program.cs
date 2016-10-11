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
            Builder a = new BuilderA();
            Builder b = new BuilderB();

            Product product =   director.build(a);
            product.Show();

        }
    }
}
