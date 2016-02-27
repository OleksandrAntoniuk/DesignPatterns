using System;

namespace DesignPatterns.Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Aggregate aggregate = new ConcreteAggregate();
            aggregate[0] = "Zero";
            aggregate[1] = "One";
            aggregate[2] = "Two";
            Iterator iterator = aggregate.CreateIterator();
            for (object i = iterator.First(); !iterator.IsDone(); i = iterator.Next())
            {
                Console.WriteLine(i);
            }
        }
    }
}