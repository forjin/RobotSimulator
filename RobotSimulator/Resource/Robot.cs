using System;
using RobotSimulator.Properties;

namespace RobotSimulator.Resource
{
    public class Robot
    {
        public Position position
        {
            get;
            set;
        }

        public Direction direction
        {
            get;
            set;
        }

        public bool isPlaced
        {
            get;
            set;
        }

        public Robot(Position pos, Direction dir)
        {
            this.position = pos;
            this.direction = dir;
        }
    }
}

