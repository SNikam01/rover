using System;
using System.Collections.Generic;
using System.Linq;

namespace Rover
{
    class Program
    {
        #region Main Methid Functionality
        static Directions.Direction direction;
        public static void Main()
        {
            try
            {
                Console.WriteLine("Enter Number of Rover");
                int RoverCount = Convert.ToInt16 (Console.ReadLine());

                Console.WriteLine("Enter X Y maximum Coordinate of Plateu ");
                var plateau = Console.ReadLine().Trim().Split(' ').Select(int.Parse).ToList();

                for (int i = 0; i < RoverCount; i++)
                {
                    Console.WriteLine("Enter Starting Point Direction Ex- 1 2 N for the Rover " + (i+1));
                    var startingPoint = Console.ReadLine().Trim().Split(' ');
                    //rover coordinates not greater than plateau 
                    if (Convert.ToInt32(startingPoint[0]) > Convert.ToInt32(plateau[0]) || Convert.ToInt32(startingPoint[1]) > Convert.ToInt32(plateau[1]))
                    {
                        Console.WriteLine("Please enter valid Input");
                        Console.ReadLine();
                        break;
                    }
                    if (startingPoint.Count() == 3)
                    {
                        SetDirection(Convert.ToString(startingPoint[2].ToUpper()));
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid Input");
                        Console.ReadLine();
                        break;
                    }
                    RoboticRover firstRoboticRover = new RoboticRover(Convert.ToInt16(startingPoint[0]), Convert.ToInt16(startingPoint[1]), direction, new Plateau(plateau[0], plateau[1]));
                    Console.WriteLine("Enter series of instructions to rover for how to explore Plateau Ex- LMLMLMLMM ");
                    var Instruction = Console.ReadLine().Trim();
                    DirectRoboticRover.Direct(firstRoboticRover, Instruction);
                    Console.WriteLine(Environment.NewLine);
                    Console.WriteLine("Output for Rover "+ (i+1));
                    GetRoboticRoverPosition.GetPosition(firstRoboticRover);
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
        #region Other Functionality
        public static void SetDirection(string strDirection)
        {
            try
            {
                if (strDirection.Trim() != null)
                {
                    switch (strDirection)
                    {
                        case "N":
                            direction = Directions.Direction.N;
                            break;
                        case "S":
                            direction = Directions.Direction.S;
                            break;
                        case "E":
                            direction = Directions.Direction.E;
                            break;
                        case "W":
                            direction = Directions.Direction.W;
                            break;
                        default:
                            break;
                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        #endregion
    }
}
