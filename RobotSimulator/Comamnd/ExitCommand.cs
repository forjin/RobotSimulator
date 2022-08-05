using System;
using RobotSimulator.Resource;

namespace RobotSimulator.Comamnd
{
    public class ExitCommand : IRobotCommand
    {
        public const string COMMAND = "EXIT";

        public ExitCommand()
        {
        }

        public void execute(Robot robot)
        {
            Environment.Exit(0);
        }
    }
}

