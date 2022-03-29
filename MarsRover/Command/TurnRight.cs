using MarsRover.Model;

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
