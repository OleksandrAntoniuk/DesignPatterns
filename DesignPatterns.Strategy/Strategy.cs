using System;

namespace DesignPatterns.Strategy
{
    abstract class Strategy
    {
        public abstract void Algorithm();
    }

    class ConcreteStrategyA : Strategy
    {
        public override void Algorithm()
        {
            Console.WriteLine("Algorithm A");
        }
    }

    class ConcreteStrategyB : Strategy
    {
        public override void Algorithm()
        {
            Console.WriteLine("Algorithm B");
        }
    }

    class ConcreteStrategyC : Strategy
    {
        public override void Algorithm()
        {
            Console.WriteLine("Algorithm C");
        }
    }

    class Context
    {
        private Strategy _strategy;
        public Context(Strategy strategy)
        {
            this._strategy = strategy;
        }
        public void ContextInterface()
        {
            _strategy.Algorithm();
        }
    }
}