using System;

namespace DesignPatterns.AbstractFactory
{
    interface IAbstractProductA { }
    interface IAbstractProductB
    {
        void Interact(IAbstractProductA apa);
    }

    class ConcreteProductA1 : IAbstractProductA { }
    class ConcreteProductA2 : IAbstractProductA { }

    class ConcreteProductB1 : IAbstractProductB
    {
        public void Interact(IAbstractProductA apa)
        {
            Console.WriteLine(this + " interacts with " + apa);        
        }
    }
    class ConcreteProductB2 : IAbstractProductB
    {
        public void Interact(IAbstractProductA apa)
        {
            Console.WriteLine(this + " interacts with " + apa);
        }
    }

    interface IAbstractFactory
    {
        IAbstractProductA CreateProductA();
        IAbstractProductB CreateProductB();
    }

    class Factory1 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }

    class Factory2 : IAbstractFactory
    {
        public IAbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }

        public IAbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}