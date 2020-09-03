using System;
using Xunit;
using Rover;

namespace RoverTest
{
    public class GetRoboticRoverPosition_Tests
    {

        [Fact]
        public void TestScanrio_14N()
        {
            RoboticRover firstRoboticRover = new RoboticRover(1, 3, Directions.Direction.N, new Plateau(5, 5));
            DirectRoboticRover.Direct(firstRoboticRover, "LMLMLMLMM");
            Assert.Equal("1 4 N", GetRoboticRoverPosition.GetPosition(firstRoboticRover));
        }
        [Fact]
        public void TestScanrio_33E()
        {
            RoboticRover firstRoboticRover = new RoboticRover(3, 3, Directions.Direction.N, new Plateau(5, 5));
            DirectRoboticRover.Direct(firstRoboticRover, "MRRMMRMRRM");
            Assert.Equal("3 2 E", GetRoboticRoverPosition.GetPosition(firstRoboticRover));
        }
        
    }
}
