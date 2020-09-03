using System;
using System.Collections.Generic;
using System.Text;

namespace Rover
{
   public static class MoveRoboticRover
    {
        /// <summary>
        /// Move X and Y for calculated direction
        /// For North and South -- Rover will move for Y direction
        /// For East and West -- Rover will move for X direction
        /// </summary>
        /// <param name="roboticRover"></param>
        public static void Move(this RoboticRover roboticRover)
        {
            if (roboticRover.RoboticRoverDirection == Directions.Direction.N && roboticRover.Plateau.Y > roboticRover.YPosition)
            {
                roboticRover.YPosition++;
            }
            else if (roboticRover.RoboticRoverDirection == Directions.Direction.E && roboticRover.Plateau.X > roboticRover.XPosition)
            {
                roboticRover.XPosition++;
            }
            else if (roboticRover.RoboticRoverDirection == Directions.Direction.S && roboticRover.YPosition > 0)
            {
                roboticRover.YPosition--;
            }
            else if (roboticRover.RoboticRoverDirection == Directions.Direction.W && roboticRover.XPosition > 0)
            {
                roboticRover.XPosition--;
            }
        }
    }
}
