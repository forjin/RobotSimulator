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
            this.direction = Direction.Parse(values[2]);
        }

        public void Execute(Robot robot)
        {
            Position newPosition = new Position(xCoordinate, yCoordinate);
            if (newPosition.IsValid)
            {
                robot.IsPlaced = true;
                robot.Position = newPosition;
                robot.Direction = this.direction;
            }
        }
    }
}

