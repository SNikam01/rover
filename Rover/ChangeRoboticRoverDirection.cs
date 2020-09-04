using System;
using System.Collections.Generic;
using System.Text;

namespace Rover
{
    public static class ChangeRoboticRoverDirection
    {
        /// <summary>
        /// This function will decide Robotic Rover Direction
        /// Example : S(270) - 90 is not less than 90 hence 270-90 = E(180) Rover Movement
        /// </summary>
        /// <param name="roboticRover"></param>
        /// <param name="direction"></param>
        public static void ChangeDirection(this RoboticRover roboticRover, char direction)
        {
            if (direction == 'L')
            {
                roboticRover.RoboticRoverDirection = (roboticRover.RoboticRoverDirection - 90) < Directions.Direction.N ? Directions.Direction.W : roboticRover.RoboticRoverDirection - 90;
            }
            else if (direction == 'R')
            {
                roboticRover.RoboticRoverDirection = (roboticRover.RoboticRoverDirection + 90) > Directions.Direction.W ? Directions.Direction.N : roboticRover.RoboticRoverDirection + 90;
            }
        }
    }
}
