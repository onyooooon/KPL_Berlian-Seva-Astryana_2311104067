using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_dp
{
    public interface ICommand
    {
        public void Execute();
    }

    public class Television
    {
        public void TurnOn()
        {
            Console.WriteLine("Television is on");
        }

        public void TurnOff()
        {
            Console.WriteLine("Television is off");
        }
    }

    public class TelevisionTurnOn : ICommand
    {
        private readonly Television? _television;

        public TelevisionTurnOn(Television? television)
        {
            _television = television;
        }

        public void Execute()
        {
            _television!.TurnOn();
        }
    }

    public class TelevisionTurnOff : ICommand
    {
        private readonly Television? _television;

        public TelevisionTurnOff(Television? television)
        {
            _television = television;
        }

        public void Execute()
        {
            _television!.TurnOff();
        }
    }

    public class RemoteTV
    {
        private ICommand? TurnOn;
        private ICommand? TurnOff;

        public void setTurnOn(ICommand command)
        {
            TurnOn = command;
        }

        public void setTurnOff(ICommand command)
        {
            TurnOff = command;
        }

        public void TurnOnTV()
        {
            TurnOn!.Execute();
        }

        public void TurnOffTV()
        {
            TurnOff!.Execute();
        }
    }
}