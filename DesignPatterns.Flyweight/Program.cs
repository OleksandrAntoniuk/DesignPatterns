namespace DesignPatterns.Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            int state = 0;
            FlyweightFactory factory = new FlyweightFactory();
            Flyweight flyweight = factory.GetFlyweight("2");
            flyweight.Operation(state);
            flyweight = factory.GetFlyweight("228");
            flyweight.Operation(state);

            flyweight = new UnsharedFlyweight();
            flyweight.Operation(state);


        }
    }
}