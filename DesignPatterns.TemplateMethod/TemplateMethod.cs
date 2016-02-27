using System;

namespace DesignPatterns.TemplateMethod
{
    abstract class ComplecatedOperation
    {
        public abstract void PrimitiveOperation1();
        public abstract void PrimitiveOperation2();

        public void TemplateMethod()
        {
            PrimitiveOperation1();
            PrimitiveOperation2();
        }
    }

    class ConcreteCompticatedOperation : ComplecatedOperation
    {
        public override void PrimitiveOperation1()
        {
            Console.WriteLine("Some simple operation 1");
        }

        public override void PrimitiveOperation2()
        {
            Console.WriteLine("Some simple operation 2");
        }
    }
}