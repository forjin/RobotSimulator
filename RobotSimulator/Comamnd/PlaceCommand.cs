using System;
using RobotSimulator.Properties;
using RobotSimulator.Resource;

namespace RobotSimulator.Comamnd
{
    public class PlaceCommand : IRobotCommand
    {
        public const string COMMAND = "PLACE";
        private int xCoordinate;
        private int yCoordinate;
        private Direction direction;

        public PlaceCommand(string parameters)
        {
            String[] values = parameters.Split(",");
            this.xCoordinate = int.Parse(values[0]);
            this.yCoordinate = int.Parse(values[1]);
            this.direction = Direction.parse(values[2]);
        }

        public void execute(Robot robot)
        {
            robot.position = new Position(xCoordinate, yCoordinate);
            robot.direction = this.direction;
            robot.isPlaced = true;
        }
    }
}

