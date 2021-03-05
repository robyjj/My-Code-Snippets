using System;

namespace DesignPatterns.Behavorial_Pattern
{
    public interface ICommand
    {
        //string Name { get; }
        void Execute();
    }

    public class StartCommand : ICommand
    {
       // public string Name => "Start";
        public void Execute()
        {
            Console.WriteLine("I am starting");
        }
    }

    public class StopCommand : ICommand
    {
        //public string Name => "Stop";
        public void Execute()
        {
            Console.WriteLine("I am stoping");
        }
    }

    public class Invoker
    {
        ICommand command;
        public ICommand GetCommand(string action)
        {
            switch(action)
            {
                case "Start":
                    command = new StartCommand();
                    break;
                case "Stop":
                    command = new StopCommand();
                    break;
            }
            return command;
        }
    }
    public class Client
    {
        public void Run()
        {
            Invoker invoke = new Invoker();
            ICommand command = invoke.GetCommand("Start");
            command.Execute();
            command = invoke.GetCommand("Stop");
            command.Execute();
        }
    }
}
