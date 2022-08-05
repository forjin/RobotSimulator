using System;
namespace RobotSimulator.Properties
{
    public class Position
    {
        public const int MIN_BOUNDARY_X = 0;
        public const int MAX_BOUNDARY_X = 5;        
        public const int MIN_BOUNDARY_Y = 0;
        public const int MAX_BOUNDARY_Y = 5;

        public int x
        {
            get;
        }
        public int y
        {
            get;
        }

        public Position()
        {
            this.x = 0;
            this.y = 0;
        }

        public Position(int x, int y)
        {
            if (x >= MIN_BOUNDARY_X && x < MAX_BOUNDARY_X && y >= MIN_BOUNDARY_Y && y < MAX_BOUNDARY_Y)
            {
                this.x = x;
                this.y = y;
            }
        }

        public override string ToString()
        {
            return "X:" + x + ", Y:" + y;
        }
    }
}

