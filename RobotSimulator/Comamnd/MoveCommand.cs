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

        public void execute(Robot robot)
        {
            Position newPosition = robot.direction.move(robot.position);
            robot.position = newPosition;
        }
    }
}

