using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    public class Director
    {
        public Product build(Builder builder)
        {
            builder.BuildPart1();
            builder.BuildPart2();
            return builder.ShowProduct();
        }
    }
}
