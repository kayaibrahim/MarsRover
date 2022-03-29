using MarsRover.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Command
{
    public class TurnRight : ICommand
    {
        public void Execute(Rover rover)
        {
            rover.TurnRight();
        }
    }
}
