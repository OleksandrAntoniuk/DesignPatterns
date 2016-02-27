namespace DesignPatterns.State
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context(new ConcreteStateA());
            context.Request(); //state B
            context.Request(); //state A
        }
    }
}