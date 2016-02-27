namespace DesignPatterns.TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ComplecatedOperation co = new ConcreteCompticatedOperation();
            co.TemplateMethod();
        }
    }
}