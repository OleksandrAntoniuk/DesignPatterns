using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Component component = new ConcreteComponent(); //man
            Decorator decoratorA = new ConcreteDecoratorA(); //man in suit
            Decorator decoratorB = new ConcreteDecoratorB();//man in suit in car

            component.Operation();
            decoratorA.Component = component;
            decoratorA.Operation();

            decoratorB.Component = decoratorA;
            decoratorB.Operation();
        }
    }
}