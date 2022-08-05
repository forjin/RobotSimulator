using System;
using RobotSimulator.Properties;
using RobotSimulator.Resource;

namespace RobotSimulator.Comamnd
{
    public class LeftCommand : IRobotCommand
    {
        public const string COMMAND = "LEFT";
        public LeftCommand()
        {
        }

        public void execute(Robot robot)
        {
            Direction currentDirection = robot.direction;
            Direction nextDirection = currentDirection;
            switch (currentDirection.facing)
            {
                case Directions.NORTH:
                    nextDirection = new Direction(Directions.WEST);
                    break;
                case Directions.WEST:
                    nextDirection = new Direction(Directions.SOUTH);
                    break;
                case Directions.SOUTH:
                    nextDirection = new Direction(Directions.EAST);
                    break;
                case Directions.EAST:
                    nextDirection = new Direction(Directions.NORTH);
                    break;
                default:
                    break;
            }
            robot.direction = nextDirection;
        }
    }
}

