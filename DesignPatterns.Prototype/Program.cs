namespace DesignPatterns.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype obj = new ConcretePrototype1("1");
            Prototype clone = obj.Clone();

            obj = new ConcretePrototype2("2");
            clone = obj.Clone();
        }
    }
}