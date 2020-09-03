using System;
using System.Collections.Generic;
using System.Text;

namespace Rover
{
   public class GetRoboticRoverPosition
    {
        public static string GetPosition(RoboticRover roboticRover)
        {
            string roverPosition = string.Format("{0} {1} {2}", roboticRover.XPosition, roboticRover.YPosition, roboticRover.RoboticRoverDirection);
            Console.WriteLine(roverPosition);
            return roverPosition;
        }
    }
}
