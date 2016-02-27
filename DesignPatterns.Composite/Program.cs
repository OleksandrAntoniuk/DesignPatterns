using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Component root = new Composite("root");
            Component branch1 = new Composite("B1");
            Component branch2 = new Composite("B2");
            Component leaf1 = new Leaf("l1");
            Component leaf2 = new Leaf("l2");
            Component leaf3 = new Leaf("l3");
            Component leaf4 = new Leaf("l4");

            root.Add(branch1);
            root.Add(branch2);

            branch1.Add(leaf1);
            branch2.Add(leaf2);
            branch2.Add(leaf3);
            branch2.Add(leaf4);

            root.Operation();

        }
    }
}
