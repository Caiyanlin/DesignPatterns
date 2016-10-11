using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    public class BuilderB : Builder
    {
        public override void BuildPart1()
        {
            product.Build("BuilderB Build Part2");
        }

        public override void BuildPart2()
        {
            product.Build("BuilderB Build Part2");
        }

        public override Product ShowProduct()
        {
            return product;
        }
    }
}
