using System;
using RobotSimulator.Resource;

namespace RobotSimulator.Comamnd
{
    public interface IRobotCommand
    {
        void Execute(Robot robot);
    }
}

