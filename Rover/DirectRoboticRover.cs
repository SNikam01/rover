using System;
using System.Collections.Generic;
using System.Text;

namespace Rover
{
    public class DirectRoboticRover
    {
        public static void Direct(RoboticRover roboticRover, string inputDirections)
        {
            char[] directions = inputDirections.ToCharArray();

            foreach (char direction in directions)
            {
                if (direction == 'L' || direction == 'R')
                    roboticRover.ChangeDirection(direction);
                else if (direction == 'M')
                    roboticRover.Move();
            }
        }
    }
}
