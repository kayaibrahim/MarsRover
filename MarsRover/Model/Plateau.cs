using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model
{
    public class Plateau
    {
        public int MinCoordinateX = 0;
        public int MinCoordinateY = 0;
        public int MaxCoordinateX { get; private set; }
        public int MaxCoordinateY { get; private set; }
        public Plateau(int maxCoordinateX, int maxCoordinateY)
        {
            MaxCoordinateX = maxCoordinateX;
            MaxCoordinateY = maxCoordinateY;
        }
    }
}
