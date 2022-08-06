using System;
namespace RobotSimulator.Properties
{
    public class Direction
    {
        public Directions Facing
        {
            get;
            set;
        }
        public Direction(Directions dir)
        {
            this.Facing = dir;
        }

        public static Direction Parse(String dir)
        {
            Direction returnDir = null;
            switch(dir)
            {
                case "NORTH":
                    returnDir = new Direction(Directions.NORTH);
                    break;
                case "SOUTH":
                    returnDir = new Direction(Directions.SOUTH);
                    break;
                case "EAST":
                    returnDir = new Direction(Directions.EAST);
                    break;
                case "WEST":
                    returnDir = new Direction(Directions.WEST);
                    break;
            }
            return returnDir;
        }


        public Position Move(Position pos)
        {
            //Console.WriteLine("CurrentPosition:" + pos.x + "," + pos.y);
            Position nextPosition = null;
            switch(this.Facing)
            {
                case Directions.NORTH:
                    nextPosition = new Position(pos.x, pos.y + 1);
                    break;
                case Directions.SOUTH:
                    nextPosition = new Position(pos.x, pos.y - 1);
                    break;
                case Directions.EAST:
                    nextPosition = new Position(pos.x + 1, pos.y);
                    break;
                case Directions.WEST:
                    nextPosition = new Position(pos.x - 1, pos.y);
                    break;
                default:
                    break;
            }
            //Console.WriteLine("NextPosition:" + nextPosition.x + "," + nextPosition.y);
            return nextPosition;
        }

        public override string ToString()
        {
            return Enum.GetName(typeof(Directions), Facing);
        }
    }
}

