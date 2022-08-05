using RobotSimulator.Comamnd;
using RobotSimulator.Properties;
using RobotSimulator.Resource;

Position pos = new Position();
Direction dir = new Direction(Directions.NORTH);
Robot r = new Robot(pos, dir);

while (true)
{

    String commandLine = Console.ReadLine();

    IRobotCommand command = CommandParser.Parse(commandLine);

    command.execute(r);

}

