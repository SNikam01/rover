namespace Rover
{
    public class RoboticRover : IRoboticRover
    {
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public Plateau Plateau { get; set; }
        public Directions.Direction RoboticRoverDirection { get; set; }

        public RoboticRover(int xPosition, int yPosition, Directions.Direction direction, Plateau plateau)
        {
            this.XPosition = xPosition;
            this.YPosition = yPosition;
            this.RoboticRoverDirection = direction;
            this.Plateau = plateau;
        }
       
    }
}
