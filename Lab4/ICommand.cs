using System.Windows.Input;

namespace Lab4
{
    internal interface ICommand
    {
        void Execute();
    }

    internal class TurnOnCommand : ICommand
    {
        private Light light;

        public TurnOnCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOn();
        }
    }

    internal class TurnOffCommand : ICommand
    {
        private Light light;

        public TurnOffCommand(Light light)
        {
            this.light = light;
        }

        public void Execute()
        {
            light.TurnOff();
        }
    }

    internal class TurnOnMusicCommand : ICommand
    {
        public string Song { get; set; }

        public TurnOnMusicCommand(string song)
        {
            Song = song;
        }

        public void Execute()
        {
            Console.WriteLine($"Turn on music {Song}");
        }
    }

    internal class RemoteControl
    {
        private ICommand commandA;
        private ICommand commandB;

        public void SetCommandA(ICommand command)
        {
            this.commandA = command;
        }

        public void SetCommandB(ICommand command)
        {
            this.commandB = command;
        }

        public void PressButtonA()
        {
            commandA.Execute();
        }
        public void PressButtonB()
        {
            commandB.Execute();
        }
    }
}
