using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter your Start poistions:");
            var startPositions = Console.ReadLine().Trim().Split(' ');
            position position = new position();

            if (startPositions.Count() == 3)
            {
                position.Coord.x = Convert.ToInt32(startPositions[0]);
                position.Coord.y = Convert.ToInt32(startPositions[1]);
                position.Direction = (Directions)Enum.Parse(typeof(Directions), startPositions[2]);
            }
            Console.WriteLine("Please Enter your Moves:");
            var moves = Console.ReadLine().ToUpper();
            position.StartMoving(moves);
            if (position.found_obstacle == true)
            {
                Console.WriteLine("Put you can savely move through:");
                Console.WriteLine(position.command_string);
            }
            Console.WriteLine("Output:");
            Console.WriteLine(position.Coord.x + " " + position.Coord.y + " " + position.Direction.ToString());
        }
        }
    }
