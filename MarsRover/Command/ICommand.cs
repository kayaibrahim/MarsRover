using MarsRover.Model;

namespace MarsRover.Command
{
    public interface ICommand
    {
        public void Execute(Rover rover);
    }
}
