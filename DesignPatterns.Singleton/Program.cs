using System;

namespace DesignPatterns.Singleton
{
    class Program
    { 
        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.GetInstance();
            Singleton instance2 = Singleton.GetInstance();
            Console.WriteLine(ReferenceEquals(instance1, instance2));
            instance1.SingletonOperation();
            string singletonData = instance1.GetSingletonData();
            Console.WriteLine(singletonData);
        }
    }
}