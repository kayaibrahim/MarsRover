using MarsRover.Model;
using Xunit;

namespace MarsRover.Tests
{
    public class PlateauTests
    {
        [Fact]
        public void CheckPlateauMaxCoordinateX()
        {
            Plateau plateau = new(5, 8);
            Assert.Equal(5, plateau.MaxCoordinateX);
        }
        [Fact]
        public void CheckPlateauMaxCoordinateY()
        {
            Plateau plateau = new(5, 8);
            Assert.Equal(8, plateau.MaxCoordinateY);
        }
        [Fact]
        public void CheckPlateauMinCoordinateX()
        {
            Plateau plateau = new(5, 8);
            Assert.Equal(0, plateau.MinCoordinateX);
        }
        [Fact]
        public void CheckPlateauMinCoordinateY()
        {
            Plateau plateau = new(5, 8);
            Assert.Equal(0, plateau.MinCoordinateY);
        }
    }
}
