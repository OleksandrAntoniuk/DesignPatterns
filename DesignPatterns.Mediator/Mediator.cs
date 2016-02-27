using System;

namespace DesignPatterns.Mediator
{
    abstract class Mediator
    {
        public abstract void Send(string message, Colleague colleague);
    }

    class ConcreteMediator : Mediator
    {
        public ConcreteColleague1 Colleague1 { get; set; }
        public ConcreteColleague2 Colleague2 { get; set; }
        public override void Send(string message, Colleague colleague)
        {
            if(Colleague1 == colleague)
            {
                Colleague2.Notify(message);
            }
            else
            {
                Colleague1.Notify(message);
            }
        }
    }

    abstract class Colleague
    {
        protected Mediator _mediator;
        public Colleague(Mediator mediator)
        {
            this._mediator = mediator;
        }
    }

    class ConcreteColleague1 : Colleague
    {
        public ConcreteColleague1(Mediator mediator) : base(mediator) { }
        public void Send(string message)
        {
            _mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }

    class ConcreteColleague2 : Colleague
    {
        public ConcreteColleague2(Mediator mediator) : base(mediator) { }
        public void Send(string message)
        {
            _mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine(message);
        }
    }
}