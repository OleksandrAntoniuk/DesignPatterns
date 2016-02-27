using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new ProxySubject();
            subject.Operation();
        }
    }
}
