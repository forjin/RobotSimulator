using RobotSimulator;
using RobotSimulator.Resource;


public class Program
{
    public static void Main(string[] args)
    {
        Robot r = new Robot();

        if (args.Length == 0)
        {
            ConsoleApplication.Main(r);
        }
        else
        {
            FileApplication.Main(r, args[0]);
        }

    }
}