using RobotSimulator.Comamnd;
using RobotSimulator.Resource;

namespace RobotSimulator
{
    public class ConsoleApplication
    {
        public static void Main(Robot r)
        {
            while (true)
            {
                String commandLine = Console.ReadLine();

                IRobotCommand command = CommandParser.Parse(commandLine);
                //Console.WriteLine("Type:" + command.GetType());
                if (r.IsPlaced || command.GetType() == typeof(PlaceCommand))
                {
                    command.Execute(r);
                }
            }

        }
    }
}

