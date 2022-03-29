﻿using MarsRover.Command;
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
    }
}
