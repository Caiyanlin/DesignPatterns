using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompositePartern
{
    public class Composite : Component
    {
        List<Component> ComponentList = new List<Component>();
        public Composite(string name)
            : base(name)
        {
        }
        public override void Add(Component component)
        {
            ComponentList.Add(component);
        }

        public override void Remove(Component component)
        {
            ComponentList.Remove(component);
        }

        public override void Operation()
        {
            Console.WriteLine(_name);

            foreach (Component item in ComponentList)
            {
                item.Operation();
            }
        }
    }
}
