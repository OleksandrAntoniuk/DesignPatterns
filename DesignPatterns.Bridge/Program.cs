namespace DesignPatterns.Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Abstraction abstraction = new RefinedAbstraction(new ConcreteImplementorA());
            abstraction.Operation();

            abstraction = new RefinedAbstraction(new ConcreteImplementorB());
            abstraction.Operation();
        }
    }
}