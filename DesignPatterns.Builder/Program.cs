namespace DesignPatterns.Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            IBuilder builder = new ConcreteBuilder();
            Director director = new Director(builder);
            director.Construct();
            Product product = builder.GetResult();
            product.Show();

            /*
            IBuilder b = new ConcreteBuilder();
            b.BuildPartA();
            b.BuildPartB();
            Product p = b.GetResult();
            p.Show();
            */
        }
    }
}