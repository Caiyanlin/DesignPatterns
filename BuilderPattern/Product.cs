using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    public class Product
    {
        string thisProduct = "";
        public void Build(string Part)
        {
            thisProduct += Part+"\r\n";
        }

        public void Show()
        {
            Console.WriteLine(thisProduct);
        }

    }
}
