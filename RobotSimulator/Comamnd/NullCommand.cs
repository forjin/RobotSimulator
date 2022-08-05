using System;
using RobotSimulator.Resource;

namespace RobotSimulator.Comamnd
{
    public class NullCommand : IRobotCommand
    {
        public NullCommand()
        {
        }

        public void execute(Robot robot)
        {
        }
    }
}

