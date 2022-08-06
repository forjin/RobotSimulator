using System;
using RobotSimulator.Properties;
using RobotSimulator.Resource;

namespace RobotSimulator.Comamnd
{
    public class MoveCommand : IRobotCommand
    {
        public const string COMMAND = "MOVE";

        public MoveCommand()
        {
        }

        public void Execute(Robot robot)
        {
            Position newPosition = robot.Direction.Move(robot.Position);
            if (newPosition.IsValid)
            {
                robot.Position = newPosition;
            }
        }
    }
}

