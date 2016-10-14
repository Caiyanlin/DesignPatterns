using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePartern
{
    public class Leaf : Component
    {
        public Leaf(string name)
            : base(name)
        {
        }
        public override void Add(Component component)
        {
            Console.WriteLine("");
        }

        public override void Remove(Component component)
        {
        }

        public override void Operation()
        {
            Console.WriteLine(_name);
        }
    }
}
