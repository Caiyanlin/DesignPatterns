using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePartern
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("root");
            Composite root1 = new Composite("A");
            root1.Add(new Leaf("-A-1"));
            root1.Add(new Leaf("-A-2"));
            Composite root2 = new Composite("B");
            root2.Add(new Leaf("-B-1"));
            root2.Add(new Leaf("-B-2"));
            root.Add(root1);
            root.Add(root2);
            root.Operation();
            Console.ReadKey();
        }
    }
}
