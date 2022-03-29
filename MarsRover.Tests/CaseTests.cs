using MarsRover.Command;
using MarsRover.Model;
using MarsRover.Types;
using Xunit;

namespace MarsRover.Tests
{
    public class CaseTests
    {
        [Fact]
        public void Case1Test()
        {
            Plateau plateau = new(5, 5);

            Rover rover = new(1, 2, DirectionType.N, plateau);

            char[] commandList = "LMLMLMLMM".ToCharArray();

            foreach (var commandChar in commandList)
            {
                ICommand command = Invoker.GetCommand(Helper.GetCharToEnum<CommandType>(commandChar.ToString()));
                command.Execute(rover);
            }
            Assert.Equal("1 3 N", rover.ToString());
        }
        [Fact]
        public void Case2Test()
        {
            Plateau plateau = new(5, 5);
            Rover rover = new(3, 3, DirectionType.E, plateau);

            char[] commandList = "MMRMMRMRRM".ToCharArray();

            foreach (var commandChar in commandList)
            {
                ICommand command = Invoker.GetCommand(Helper.GetCharToEnum<CommandType>(commandChar.ToString()));
                command.Execute(rover);
            }
            Assert.Equal("5 1 E", rover.ToString());
        }
        [Fact]
        public void CaseRoverCantMoveNorthPlateauLimitTest()
        {
            Plateau plateau = new(5, 5);
            Rover rover = new(5, 5, DirectionType.N, plateau);

            char[] commandList = "M".ToCharArray();

            foreach (var commandChar in commandList)
            {
                ICommand command = Invoker.GetCommand(Helper.GetCharToEnum<CommandType>(commandChar.ToString()));
                command.Execute(rover);
            }
            Assert.Equal("5 5 N", rover.ToString());
        }
        [Fact]
        public void CaseRoverCantMoveEastPlateauLimitTest()
        {
            Plateau plateau = new(5, 5);
            Rover rover = new(5, 5, DirectionType.E, plateau);

            char[] commandList = "M".ToCharArray();

            foreach (var commandChar in commandList)
            {
                ICommand command = Invoker.GetCommand(Helper.GetCharToEnum<CommandType>(commandChar.ToString()));
                command.Execute(rover);
            }
            Assert.Equal("5 5 E", rover.ToString());
        }
        [Fact]
        public void CaseRoverCantMoveSouthPlateauLimitTest()
        {
            Plateau plateau = new(5, 5);
            Rover rover = new(0, 0, DirectionType.S, plateau);

            char[] commandList = "M".ToCharArray();

            foreach (var commandChar in commandList)
            {
                ICommand command = Invoker.GetCommand(Helper.GetCharToEnum<CommandType>(commandChar.ToString()));
                command.Execute(rover);
            }
            Assert.Equal("0 0 S", rover.ToString());
        }
        [Fact]
        public void CaseRoverCantMoveWestPlateauLimitTest()
        {
            Plateau plateau = new(5, 5);
            Rover rover = new(0, 0, DirectionType.W, plateau);

            char[] commandList = "M".ToCharArray();

            foreach (var commandChar in commandList)
            {
                ICommand command = Invoker.GetCommand(Helper.GetCharToEnum<CommandType>(commandChar.ToString()));
                command.Execute(rover);
            }
            Assert.Equal("0 0 W", rover.ToString());
        }
    }
}
