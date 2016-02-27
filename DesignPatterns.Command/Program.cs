namespace DesignPatterns.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            invoker.StoreCommand(command);
            invoker.ExecuteCommand();
        }
    }
}