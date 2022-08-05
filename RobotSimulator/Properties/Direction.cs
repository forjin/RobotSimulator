using System;
namespace RobotSimulator.Properties
{
    public class Direction
    {
        public Directions facing
        {
            get;
            set;
        }
        public Direction(Directions dir)
        {
            this.facing = dir;
        }

        public static Direction parse(String dir)
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


        public Position move(Position pos)
        {
            Position nextPosition = pos;
            switch(this.facing)
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
            return nextPosition;
        }

        public override string ToString()
        {
            return Enum.GetName(typeof(Directions), facing);
        }
    }
}

