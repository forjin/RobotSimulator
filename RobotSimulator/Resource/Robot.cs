using System;
using RobotSimulator.Properties;

namespace RobotSimulator.Resource
{
    public class Robot
    {
        public Position Position
        {
            get;
            set;
        }

        public Direction Direction
        {
            get;
            set;
        }

        public bool IsPlaced
        {
            get;
            set;
        }

        public Robot()
        {
        }

        public Robot(Position pos, Direction dir)
        {
            this.Position = pos;
            this.Direction = dir;
        }
    }
}

