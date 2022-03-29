using MarsRover.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model
{
    public class Rover
    {
        public int CoordinateX { get; set; }
        public int CoordinateY { get; set; }
        public DirectionType Direction { get; set; }
        public Plateau Plateau { get; set; }
        private List<(int, int, DirectionType)> CrashZones { get; set; }
        public Rover(int coordinateX, int coordinateY, DirectionType direction, Plateau plateau)
        {
            CoordinateX = coordinateX;
            CoordinateY = coordinateY;
            Direction = direction;
            Plateau = plateau;
        }

        public void TurnLeft()
        {
            switch (Direction)
            {
                case DirectionType.E:
                    Direction = DirectionType.N;
                    break;
                case DirectionType.N:
                    Direction = DirectionType.W;
                    break;
                case DirectionType.W:
                    Direction = DirectionType.S;
                    break;
                case DirectionType.S:
                    Direction = DirectionType.E;
                    break;
            }
        }

        public void TurnRight()
        {
            switch (Direction)
            {
                case DirectionType.E:
                    Direction = DirectionType.S;
                    break;
                case DirectionType.N:
                    Direction = DirectionType.E;
                    break;
                case DirectionType.W:
                    Direction = DirectionType.N;
                    break;
                case DirectionType.S:
                    Direction = DirectionType.W;
                    break;
            }
        }

        public void Move()
        {
            switch (Direction)
            {
                case DirectionType.E:
                    if (!CheckEastMove())
                        CoordinateX += 1;
                    break;
                case DirectionType.N:
                    if (!CheckNorthMove())
                        CoordinateY += 1;
                    break;
                case DirectionType.W:
                    if (!CheckWestMove())
                        CoordinateX -= 1;
                    break;
                case DirectionType.S:
                    if (!CheckSouthMove())
                        CoordinateY -= 1;
                    break;
            }
        }
        private bool CheckEastMove() => CoordinateX == Plateau.MaxCoordinateX;
        private bool CheckNorthMove() => CoordinateY == Plateau.MaxCoordinateY;
        private bool CheckWestMove() => CoordinateX == Plateau.MinCoordinateX;
        private bool CheckSouthMove() => CoordinateY == Plateau.MinCoordinateY;

        public override string ToString() => CoordinateX + " " + CoordinateY + " " + Direction;
    }
}
