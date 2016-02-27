using System;

namespace DesignPatterns.Decorator
{
    abstract class Component
    {
        public abstract void Operation();
    }

    class ConcreteComponent : Component
    {
        public override void Operation()
        {
            Console.WriteLine("Concrete component");
        }
    }

    abstract class Decorator : Component
    {
        public Component Component { protected get; set; }
        public override void Operation()
        {
            if(Component != null)
            {
                Component.Operation();
            }
        }
    }

    class ConcreteDecoratorA : Decorator
    {
        private string _somePart = "Some part";
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine(_somePart);
        }
    }

    class ConcreteDecoratorB : Decorator
    {
        private void AddedBehavior()
        {
            Console.WriteLine("Added Behavior");
        }

        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }
    }
}