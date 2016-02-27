using System.Collections;

namespace DesignPatterns.Flyweight
{
    abstract class Flyweight
    {
        public abstract void Operation(int state);
    }

    class ConcreteFlyweight : Flyweight
    {
        private int _intrinsicState;
        public override void Operation(int state)
        {
            _intrinsicState = state;
        }
    }

    class UnsharedFlyweight : Flyweight
    {
        private int _allState;
        public override void Operation(int state)
        {
            _allState = state;
        }
    }

    class FlyweightFactory
    {
        private Hashtable _hiddenPool = new Hashtable
        {
            {"1", new ConcreteFlyweight() },
            {"2", new ConcreteFlyweight() },
            {"3", new ConcreteFlyweight() },
        };

        public Flyweight GetFlyweight(string key)
        {
            if (!_hiddenPool.ContainsKey(key))
                _hiddenPool.Add(key, new ConcreteFlyweight());
            return _hiddenPool[key] as Flyweight;
        }
    }
}