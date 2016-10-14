using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePartern
{
    public abstract class Component
    {
        protected string _name;

        public Component(string name)
        {
            _name = name;
        }
        public abstract void Operation();

        public abstract void Add(Component component);

        public abstract void Remove(Component component);

    }
}
