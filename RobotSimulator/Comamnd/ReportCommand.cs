using System;
using RobotSimulator.Resource;

namespace RobotSimulator.Comamnd
{
    public class ReportCommand : IRobotCommand
    {
        public const string COMMAND = "REPORT";

        public ReportCommand()
        {
        }

        public void execute(Robot robot)
        {
            Console.WriteLine("Position:" + robot.position.ToString());
            Console.WriteLine("Direction:" + robot.direction.ToString());
        }
    }
}

