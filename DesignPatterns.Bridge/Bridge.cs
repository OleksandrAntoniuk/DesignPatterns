using System;

namespace DesignPatterns.Bridge
{
    //bridge beetween Implementor and RefinedAbstaction
    abstract class Abstraction
    {
        protected Implementor _implementor;
        public Abstraction(Implementor implementor)
        {
            this._implementor = implementor;
        }
        public virtual void Operation()
        {
            this._implementor.ImplementorOperation();
        }
    }

    class RefinedAbstraction : Abstraction
    {
        public RefinedAbstraction(Implementor implementor) : base(implementor) { }
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Refined Abstraction Operation");
        }
    }

    abstract class Implementor
    {
        public abstract void ImplementorOperation();
    }
    class ConcreteImplementorA : Implementor
    {
        public override void ImplementorOperation()
        {
            Console.WriteLine("This is A Implementor");
        }
    }
    class ConcreteImplementorB : Implementor
    {
        public override void ImplementorOperation()
        {
            Console.WriteLine("This is B Implementor");
        }
    }
}