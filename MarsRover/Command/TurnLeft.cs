using MarsRover.Model;

namespace MarsRover.Command
{
    public class TurnLeft : ICommand
    {
        public void Execute(Rover rover)
        {
            rover.TurnLeft();
        }
    }
}
