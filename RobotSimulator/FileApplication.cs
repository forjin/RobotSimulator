using RobotSimulator.Comamnd;
using RobotSimulator.Resource;

namespace RobotSimulator
{
    public class FileApplication
    {
        public FileApplication()
        {
        }

        public static void Main(Robot r, string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string lineCommand in lines)
            {
                IRobotCommand command = CommandParser.Parse(lineCommand);
                //Console.WriteLine("Type:" + command.GetType());
                if (r.IsPlaced || command.GetType() == typeof(PlaceCommand))
                {
                    command.Execute(r);
                }
            }

        }

    }
}

