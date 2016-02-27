using System;

namespace DesignPatterns.Command
{
    class Receiver
    {
        public void Action()
        {
            Console.WriteLine("Receiver action");
        }
    }

        abstract class Command
        {
            protected Receiver _receiver;
            public Command(Receiver receiver)
            {
                this._receiver = receiver;
            }
            public abstract void Execute();
        }

        class ConcreteCommand : Command
        {
            public ConcreteCommand(Receiver receiver) : base(receiver) { }
            public override void Execute()
            {
                _receiver.Action();
            }
        }

        class Invoker
        {
            private Command _command;
            public void StoreCommand(Command command)
            {
                this._command = command;
            }
            public void ExecuteCommand()
            {
                this._command.Execute();
            }
        }
}