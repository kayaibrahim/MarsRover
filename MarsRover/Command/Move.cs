using MarsRover.Model;

namespace MarsRover.Command
{
    public class Move : ICommand
    {
        public void Execute(Rover rover)
        {
            rover.Move();
        }
    }
}
