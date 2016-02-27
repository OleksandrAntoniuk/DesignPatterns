using System;

namespace DesignPatterns.Facade
{
    class Facade
    {
        SubSystemA subSystemA = new SubSystemA();
        SubSystemB subSystemB = new SubSystemB();
        SubSystemC subSystemC = new SubSystemC();
        public void OperationAB()
        {
            subSystemA.OperationA();
            subSystemB.OperationB();
        }
        public void OperationBC()
        {
            subSystemB.OperationB();
            subSystemC.OperationC();
        }
    }

    class SubSystemA
    {
        public void OperationA()
        {
            Console.WriteLine("SubSystem A");
        }
    }

    class SubSystemB
    {
        public void OperationB()
        {
            Console.WriteLine("SubSystem B");
        }
    }

    class SubSystemC
    {
        public void OperationC()
        {
            Console.WriteLine("SubSystem C");
        }
    }
}