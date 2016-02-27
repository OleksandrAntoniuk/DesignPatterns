using System;
using System.Collections;

namespace DesignPatterns.Observer
{
    #region PULL_METHOD
    abstract class Observer
    {
        public abstract void Update();
    }

    abstract class Subject
    {
        private ArrayList _observers = new ArrayList();
        public void Attach(Observer observer)
        {
            _observers.Add(observer);
        }
        public void Detach(Observer observer)
        {
            _observers.Remove(observer);
        }
        public void Notify()
        {
            foreach (Observer observer in _observers)
            {
                observer.Update();
            }
        }
    }

    class ConcreteSubject : Subject
    {
        public string State { get; set; }
    }

    class ConcreteObserver : Observer
    {
        private string _state;
        private ConcreteSubject _subject;

        public ConcreteObserver(ConcreteSubject subject)
        {
            this._subject = subject;
        }
        public override void Update()
        {
            _state = _subject.State;
        }
    }
    #endregion

    #region PUSH_METHOD
    abstract class Observer2
    {
        public abstract void Update(string state);
    }

    abstract class Subject1
    {
        ArrayList observers = new ArrayList();
        public void Attach(Observer2 observer)
        {
            observers.Add(observer);
        }
        public void Detach(Observer2 observer)
        {
            observers.Remove(observer);
        }
        public virtual string State { get; set; }
        public void Notify()
        {
            foreach (Observer2 observer in observers)
                observer.Update(State);
        }
    }

    class ConcreteSubject1 : Subject1
    {
        public override string State { get; set; }
    }

    class ConcreteObserver2 : Observer2
    {
        private string _observerState;
        private ConcreteSubject1 _subject;
        public ConcreteObserver2(ConcreteSubject1 subject)
        {
            this._subject = subject;
        }
        public override void Update(string state)
        {
            _observerState = state;
        }
    }
    #endregion
}