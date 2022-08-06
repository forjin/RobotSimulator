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

        public void Execute(Robot robot)
        {
            Console.WriteLine("Position:" + robot.Position.ToString());
            Console.WriteLine("Direction:" + robot.Direction.ToString());
        }
    }
}

