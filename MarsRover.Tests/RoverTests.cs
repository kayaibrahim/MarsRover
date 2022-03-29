using MarsRover.Model;
using MarsRover.Types;
using Xunit;

namespace MarsRover.Tests
{
    public class RoverTests
    {
        [Fact]
        public void CoordinateXTest()
        {
            Plateau plateau = new(5, 5);

            Rover rover = new(3, 4, DirectionType.E, plateau);
            Assert.Equal(3, rover.CoordinateX);
        }
        [Fact]
        public void CoordinateYTest()
        {
            Plateau plateau = new(5, 5);

            Rover rover = new(3, 4, DirectionType.E, plateau);
            Assert.Equal(4, rover.CoordinateY);
        }
        [Fact]
        public void DirectionTest()
        {
            Plateau plateau = new(5, 5);

            Rover rover = new(3, 4, DirectionType.E, plateau);
            Assert.Equal(DirectionType.E, rover.Direction);
        }
        [Fact]
        public void TurnLeftTest()
        {
            Plateau plateau = new(5, 5);

            Rover rover = new(3, 3, DirectionType.E, plateau);
            rover.TurnLeft();
            Assert.Equal(DirectionType.N, rover.Direction);
        }
        [Fact]
        public void TurnRightTest()
        {
            Plateau plateau = new(5, 5);

            Rover rover = new(3, 3, DirectionType.E, plateau);
            rover.TurnRight();
            Assert.Equal(DirectionType.S, rover.Direction);
        }
        [Fact]
        public void MoveTest()
        {
            Plateau plateau = new(5, 5);

            Rover rover = new(3, 3, DirectionType.E, plateau);
            rover.Move();
            Assert.Equal(4, rover.CoordinateX);
        }
    }
}