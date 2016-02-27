namespace DesignPatterns.Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade facade = new Facade();
            facade.OperationAB();
            facade.OperationBC();
        }
    }
}