using System;

namespace RobotSimulator.Comamnd
{
    public class CommandParser
    {
        public CommandParser()
        {
        }

        public static IRobotCommand Parse(String command)
        {
            String[] elements = command.Split(" ");

            String firstElement = elements[0];

            IRobotCommand robotCommand = null;
            switch (firstElement)
            {
                case LeftCommand.COMMAND:
                    robotCommand = new LeftCommand();
                    break;
                case RightCommand.COMMAND:
                    robotCommand = new RightCommand();
                    break;
                case MoveCommand.COMMAND:
                    robotCommand = new MoveCommand();
                    break;
                case PlaceCommand.COMMAND:
                    robotCommand = new PlaceCommand(elements[1]);
                    break;
                case ReportCommand.COMMAND:
                    robotCommand = new ReportCommand();
                    break;
                case ExitCommand.COMMAND:
                    robotCommand = new ExitCommand();
                    break;
                default:
                    robotCommand = new NullCommand();
                    break;
            }

            return robotCommand;
        }
    }
}

