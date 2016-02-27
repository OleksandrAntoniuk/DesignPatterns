using System;

namespace DesignPatterns.FactoryMethod
{
    abstract class Product { }

    class ConcreteProduct : Product
    {
        public ConcreteProduct()
        {
            Console.WriteLine("Concrete product created");
        }
    }

    abstract class Creator
    {
        private Product _product;
        public abstract Product FactoryMethod();

        public void Operation()
        {
            this._product = FactoryMethod();
        }
    }

    class ConcreteCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}