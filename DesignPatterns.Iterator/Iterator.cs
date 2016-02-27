using System.Collections;

namespace DesignPatterns.Iterator
{
    abstract class Iterator
    {
        public abstract object First();
        public abstract object Next();
        public abstract object Current();
        public abstract bool IsDone();
    }

    class ConcreteIterator : Iterator
    {
        private Aggregate _aggregate;
        private int _current = 0;
        public ConcreteIterator(Aggregate aggregate)
        {
            this._aggregate = aggregate;
        }
        public override object Current()
        {
            return _aggregate[_current];
        }

        public override object First()
        {
            return _aggregate[0];
        }

        public override bool IsDone()
        {
            if(_current < _aggregate.Count)
            {
                return false;
            }
            else
            {
                _current = 0;
                return true;
            }
           
        }

        public override object Next()
        {
            //was book mistake - p. 206 "OOD via C#"
            if (++_current < _aggregate.Count)
            {
                return _aggregate[_current];
            }
            else
            {
                return null;
            }
        }
    }

    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
        public abstract int Count { get; }
        public abstract object this[int index] { get; set; }
    }

    class ConcreteAggregate : Aggregate
    {
        private ArrayList _items = new ArrayList();
        public override object this[int index]
        {
            get
            {
                return _items[index];
            }

            set
            {
                _items.Insert(index, value);
            }
        }

        public override int Count
        {
            get
            {
                return _items.Count;
            }
        }

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
    }
}
