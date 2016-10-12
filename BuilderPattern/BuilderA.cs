using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    public class BuilderA : Builder
    {
        public override void BuildPart1()
        {
            product.Build("Builder A Build Part1");
        }

        public override void BuildPart2()
        {
            product.Build("Builder A Build Part2");
        }

        public override Product ShowProduct()
        {
            return product;
        }
    }
}
