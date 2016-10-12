using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BuilderPattern
{
    public abstract class Builder
    {
        protected Product product = new Product();
        public abstract void BuildPart1();

        public abstract void BuildPart2();

        public abstract Product ShowProduct();

    }
}
