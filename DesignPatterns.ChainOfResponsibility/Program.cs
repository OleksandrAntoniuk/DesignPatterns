namespace DesignPatterns.ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler handler1 = new ConcreteHandler1();
            Handler handler2 = new ConcreteHandler2();
            handler1.Successor = handler2;
            handler1.HandleRequest(1);
            handler1.HandleRequest(2);
        }
    }
}