namespace DesignPatterns.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client(new Factory1());
            client.Demo();

            client = new Client(new Factory2());
            client.Demo();
        }
    }

    class Client
    {
        private IAbstractProductA _a;
        private IAbstractProductB _b;
        public Client(IAbstractFactory factory)
        {
            this._a = factory.CreateProductA();
            this._b = factory.CreateProductB();
        }

        public void Demo()
        {
            this._b.Interact(this._a);
        }
    }
}
