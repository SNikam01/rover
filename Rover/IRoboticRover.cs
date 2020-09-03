using System;
using System.Collections.Generic;
using System.Text;

namespace Rover
{
   public interface IRoboticRover
    {
        Plateau Plateau { get; set; }
        Directions.Direction RoboticRoverDirection { get; set; }
        int XPosition { get; set; }
        int YPosition { get; set; }
    }
}
