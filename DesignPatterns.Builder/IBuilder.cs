using System;
using System.Collections;

namespace DesignPatterns.Builder
{
    //finished product
    class Product
    {
        private ArrayList _parts = new ArrayList();
        public void Add(string part)
        {
            this._parts.Add(part);
        }
        public void Show()
        {
            foreach(var p in this._parts)
            {
                Console.WriteLine(p);
            }
        }
    }

    //parts of building
    interface IBuilder
    {
        void BuildPartA();
        void BuildPartB();
        void BuildPartC();
        Product GetResult();
    }
    
    class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();
        public void BuildPartA()
        {
            this._product.Add("A");
        }

        public void BuildPartB()
        {
            this._product.Add("B");
        }

        public void BuildPartC()
        {
            this._product.Add("C");
        }

        public Product GetResult()
        {
            return this._product;
        }
    }
    
    //what we want to build
    class Director
    {
        private IBuilder _builder;
        public Director(IBuilder builder)
        {
            this._builder = builder;
        }

        public void Construct()
        {
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }
    }
}
