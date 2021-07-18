using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    //enumerable type to detect direction
    public enum Directions
    {
        N,//for North
        S,//for South
        E,//for East
        W//for West
    }
    //class for the coordinates
    public class Coordinate
    {
        public int x;
        public int y;
    }
    public class position
    {
        public Coordinate Coord;//Coordinates for x and y direction
        public Directions Direction { get; set; } //Direction
        public List<Coordinate> obstacles = new List<Coordinate>();// list condatins obstacles coordinates
        public bool obstacle; // to verify obstacle or not
        public string command_string; // command for the rover that will meet an obstacle
        public bool found_obstacle; // at leat one obstacle found
        public position() //constructor
        {
            Coord = new Coordinate();
            Coord.x = Coord.y= 0;
            Direction = Directions.N;
        }
        private void Rotate90Right()
        {
            command_string+='R';
            switch (Direction)
            {
                case Directions.N:
                    Direction = Directions.E;
                    break;
                case Directions.S:
                    Direction = Directions.W;
                    break;
                case Directions.E:
                    Direction = Directions.S;
                    break;
                case Directions.W:
                    Direction = Directions.N;
                    break;
                default:
                    break;
            }
        }
        private void Rotate90Left()
        {
            command_string += 'L';
            switch (this.Direction)
            {
                case Directions.N:
                    Direction = Directions.W;
                    break;
                case Directions.S:
                    Direction = Directions.E;
                    break;
                case Directions.E:
                    Direction = Directions.N;
                    break;
                case Directions.W:
                    Direction = Directions.S;
                    break;
                default:
                    break;
            }
        }
        private void MoveForward(char move)
        {
           
            switch (Direction)
            {
                
                case Directions.N: incrementY(move);
                    break;

                case Directions.S: decrementY(move);
                    break;

                case Directions.E: incrementX(move);
                    break;

                case Directions.W: decrementX(move);
                    break;
                default:
                    break;
            }
        }
        private void MoveBackward(char move)
        {
            switch (Direction)
            {
                case Directions.N: decrementY(move);
                    break;

                case Directions.S: incrementY(move);
                    break;

                case Directions.E: decrementX(move);
                    break;

                case Directions.W: incrementX(move);
                    break;
                default:
                    break;
            }
        }

        //method to increment rover's x position
        private void incrementX(char move)
        {
            if (obstacle == true)
                obstacle = false;
            Coord.x = Coord.x + 1;
            for (int i = 0; i < obstacles.Count; i++)
            {
                if (obstacles[i].x == Coord.x&&obstacles[i].y == Coord.y)
                {
                    Coord.x -= 1;
                    Console.WriteLine("obtsacle (" + Coord.x + ", " + Coord.y + ") " + Direction.ToString() + " STOPPED");
                    obstacle = true;
                    found_obstacle = true;
                    if (move == 'F')
                    {
                        move = 'B';
                        MoveBackward(move);
                    }
                    else
                    {
                        move = 'F';
                        MoveForward(move);
                    }
                    return;
                }
            }
            if (obstacle == false)
            {
                if (move == 'F')
                    command_string += 'F';
                else
                    command_string += 'B';
            }

        }

        //method to decrement rover's x position
        private void decrementX(char move)
        {

            if (obstacle == true)
                obstacle = false;
            Coord.x = Coord.x - 1;
            for (int i = 0; i < obstacles.Count; i++)
            {
                if (obstacles[i].x == Coord.x && obstacles[i].y == Coord.y)
                {
                    Coord.x += 1;
                    Console.WriteLine("obtsacle (" + Coord.x + ", " + Coord.y + ") " + Direction.ToString() + " STOPPED");
                    obstacle = true;
                    found_obstacle = true;
                    if (move == 'F')
                    {
                        move = 'B';
                        MoveBackward(move);
                    }
                    else
                    {
                        move = 'F';
                        MoveForward(move);
                    }
                    return;
                }
               
            }
            if (obstacle == false)
            {
                if (move == 'F')
                    command_string += 'F';
                else
                    command_string += 'B';
            }
        }

        //method to increment rover's y position
        private void incrementY(char move)
        {
            if (obstacle == true)
                obstacle = false;
            Coord.y = Coord.y + 1;
            for (int i = 0; i < obstacles.Count; i++)
            {
                if (obstacles[i].x == Coord.x && obstacles[i].y == Coord.y)
                {
                    Coord.y -= 1;
                    Console.WriteLine("obtsacle (" + Coord.x + ", " + Coord.y + ") " + Direction.ToString() + " STOPPED");
                    obstacle = true;
                    found_obstacle = true;
                    if (move == 'F')
                    {
                        move = 'B';
                        MoveBackward(move);
                    }
                    else
                    {
                        move = 'F';
                        MoveForward(move);
                    }
                    return;
                }
            }
            if (obstacle == false)
            {
                if (move == 'F')
                    command_string += 'F';
                else
                    command_string += 'B';
            }
        }

        //method to decrement rover's y position
        private void decrementY(char move)
        {

            if (obstacle == true)
                obstacle = false;
            Coord.y = Coord.y - 1;
            for (int i = 0; i < obstacles.Count; i++)
            {
                if (obstacles[i].x == Coord.x && obstacles[i].y == Coord.y)
                {
                    Coord.y += 1;
                    Console.WriteLine("obtsacle (" + Coord.x + ", " + Coord.y + ") " + Direction.ToString() + " STOPPED");
                    obstacle = true;
                    found_obstacle = true;
                    if (move == 'F')
                    {
                        move= 'B';
                        MoveBackward(move);
                    }
                    else
                    {
                        move = 'F';
                        MoveForward(move);
                    }
                    return;
                }
            }
            if (obstacle == false)
            {
                if (move == 'F')
                    command_string += 'F';
                else
                    command_string += 'B';
            }
        }
        // movement for the rover
        public void StartMoving(string moves)
        {
            obstacles.Add(new Coordinate()
            {
                x = 1,
                y = 4
            });
            obstacles.Add(new Coordinate()
            {
                x = 3,
                y = 5
            });
            obstacles.Add(new Coordinate()
            {
                x = 7,
                y = 4
            });
            foreach (var move in moves)
            {
                switch (move)
                {
                    case 'F':
                        MoveForward(move);
                        break;
                    case 'B':
                        MoveBackward(move);
                        break;
                    case 'L':
                        Rotate90Left();
                        break;
                    case 'R':
                        Rotate90Right();
                        break;
                    default:
                        Console.WriteLine("Invalid Move");
                        break;
                }
            }
        }
    }
   
}
