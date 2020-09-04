using System;
using System.Collections.Generic;
using System.Text;

namespace Rover
{
    public class Plateau : IPlateau
    {
        //Width of the Plateau.
        public int X { get ; set; }
        //Height of the Plateau.
        public int Y { get; set; }

        public Plateau(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}
