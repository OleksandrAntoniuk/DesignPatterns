using System;

namespace DesignPatterns.Proxy
{
    abstract class Subject
    {
        public abstract void Operation();
    }

    class RealSubject : Subject
    {
        public override void Operation()
        {
            Console.WriteLine("Real subject operation");
        }
    }

    class ProxySubject : Subject
    {
        private RealSubject _subject = new RealSubject();

        public override void Operation()
        {
            _subject.Operation();
        }
    }
}