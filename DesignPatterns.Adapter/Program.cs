namespace DesignPatterns.Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //class level
            ITarget t1 = new Adapter();
            Adaptee t2 = new Adapter();
            t1.Request();
            t2.SpecificReques();

            //object level
            Target t3 = new AdapterObject();
            t3.Request();
        }
    }
}