using System;
using System.Collections;

namespace DesignPatterns.Composite
{
    abstract class Component
    {
        protected string _name;
        public Component(string name)
        {
            this._name = name;
        }
        public abstract void Operation();
        public abstract void Add(Component component);
        public abstract void Remove(Component component);
        public abstract Component GetChild(int index);
    }

    class Composite : Component
    {
        private ArrayList _nodes = new ArrayList();
        public Composite(string name) : base(name) { }
        public override void Add(Component component)
        {
            _nodes.Add(component);
        }

        public override Component GetChild(int index)
        {
            return _nodes[index] as Component;
        }

        public override void Operation()
        {
            Console.WriteLine(_name);
            foreach (Component item in _nodes)
            {
                item.Operation();
            }
        }

        public override void Remove(Component component)
        {
            _nodes.Remove(component);
        }
    }

    class Leaf : Component
    {
        public Leaf(string name) : base(name) { }
        public override void Add(Component component)
        {
            throw new InvalidOperationException();
        }

        public override Component GetChild(int index)
        {
            throw new InvalidOperationException();
        }

        public override void Operation()
        {
            Console.WriteLine(_name);
        }

        public override void Remove(Component component)
        {
            throw new InvalidOperationException();
        }
    }
}