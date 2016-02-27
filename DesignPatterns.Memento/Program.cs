namespace DesignPatterns.Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator origin = new Originator();
            origin.State = "ON";

            CareTaker care = new CareTaker();
            care.Memento = origin.CreateMemento();

            origin.State = "OFF";
            origin.SetMemento(care.Memento);
        }
    }
}