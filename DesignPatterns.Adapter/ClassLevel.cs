using System;
namespace DesignPatterns.Adapter
{
    interface ITarget
    {
        void Request();
    }

    class Adaptee
    {
        public void SpecificReques()
        {
            Console.WriteLine("Specific request");
        }
    }

    class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            SpecificReques();
        }
    }
}