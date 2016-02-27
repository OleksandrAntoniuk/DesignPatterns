namespace DesignPatterns.Prototype
{
    abstract class Prototype
    {
        public string Id { get; private set; }
        public Prototype(string id)
        {
            this.Id = id;
        }
        public abstract Prototype Clone();
    }

    class ConcretePrototype1 : Prototype
    {
        public ConcretePrototype1(string id) : base(id) { }
        public override Prototype Clone()
        {
            return new ConcretePrototype1(Id);
        }
    }

    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(string id) : base(id) { }
        public override Prototype Clone()
        {
            return new ConcretePrototype2(Id);
        }
    }
}