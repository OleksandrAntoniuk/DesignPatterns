using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter
{
    abstract class Target
    {
        public abstract void Request();
    }

    class AdapteeObject
    {
        public void SpecificRequest()
        {
            Console.WriteLine("Object specific request");
        }
    }

    class AdapterObject : Target
    {
        AdapteeObject adaptee = new AdapteeObject();
        public override void Request()
        {
            adaptee.SpecificRequest();
        }
    }
}