namespace DesignPatterns.Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subj = new ConcreteSubject();
            subj.Attach(new ConcreteObserver(subj));
            subj.Attach(new ConcreteObserver(subj));

            subj.State = "Some state";
            subj.Notify();

            ConcreteSubject1 subj1 = new ConcreteSubject1();
            subj1.Attach(new ConcreteObserver2(subj1));
            subj1.Attach(new ConcreteObserver2(subj1));

            subj1.State = "Some state 1";
            subj1.Notify();


        }
    }
}